Imports System.Data.SqlClient
Public Class PlaceOrder
    Inherits System.Web.UI.Page
    Dim sConn As String = "Data Source=PRASANNASPC\SRINISQL;Initial Catalog=EcomSkel;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim conn As New SqlConnection(sConn)
        Dim ssql As String = "select productcode, productdesc, productprice, productunit from tblProducts order by productname"
        conn.Open()
        Dim cmd As New SqlCommand(ssql, conn)
        Dim dt As New DataTable
        dt.Load(cmd.ExecuteReader)
        grdOrders.DataSource = dt
        conn.Close()
    End Sub

    Protected Sub btnPlaceOrder_click(ByVal sender As Object, e As System.EventArgs) Handles btnPlaceOrder.Click
        Dim username As String
        If Session("Customer") IsNot Nothing Then
            Dim oCart As New clsCart
            Dim oCustomer As clsCustomer = Session("Customer")
            username = oCustomer.custusername
            oCart.orderdetail = New List(Of Tuple(Of Integer, Decimal))
            oCart.orderRawTotal = 0
            Dim ssql As String
            Dim cmdSave As SqlCommand
            Dim conn As New SqlConnection(sConn)
            conn.Open()
            Dim sOrdrWarn As String = "Not enough stock in following products to fullfil order:  "
            conn.Open()
            Dim cntNoOrd As Integer = 0
            For Each grw As DataGridItem In grdOrders.Items
                ssql = "select productstockonhand, productid, productprice from tblproducts where productcode = @prodno"
                Dim cmd As New SqlCommand(ssql, conn)
                cmd.Parameters.AddWithValue("@prodno", grw.Cells(0).Text)
                Dim dt1 As New DataTable
                dt1.Load(cmd.ExecuteReader)
                Dim instock As Decimal = dt1.Rows(0).Field(Of Decimal)(0)
                Dim prodid As Integer = dt1.Rows(0).Field(Of Integer)(1)
                Dim prodprice As Decimal = dt1.Rows(0).Field(Of Decimal)(2)
                Dim iOrd As Decimal
                Dim txqt As TextBox = grw.FindControl("txtQty")
                If Not String.IsNullOrEmpty(txqt.Text) Then
                    iOrd = Decimal.Parse(txqt.Text)
                    If iOrd > instock Then
                        Dim chkqty As CheckBox = grw.FindControl("chkEnuf")
                        chkqty.Checked = False
                        sOrdrWarn = grw.Cells(0).Text + ", "
                        cntNoOrd = cntNoOrd + 1
                    Else
                        Dim orTuple As New Tuple(Of Integer, Decimal)(prodid, iOrd)
                        oCart.orderdetail.Add(orTuple)
                        oCart.orderRawTotal = oCart.ordertotal + iOrd * prodprice
                    End If
                End If
            Next
            oCart.ordertotal = Session("Cart").orderRawTotal
            If Not String.IsNullOrEmpty(txtDscnt.Text) Then
                Dim discnt As Decimal = Decimal.Parse(txtDscnt.Text)
                If discnt < 100 Then
                    oCart.orderdisc = discnt
                    oCart.ordertotal = Session("Cart").ordertotal * (1 - discnt / 100)
                Else
                    sOrdrWarn = sOrdrWarn + " discount too high -- not applied, "
                End If
            End If
            If Not String.IsNullOrEmpty(txtRebate.Text) Then
                Dim rebate As Decimal = Decimal.Parse(txtRebate.Text)
                If rebate < Session("Cart").orderTotal Then
                    Session("Cart").orderRebate = rebate
                    Session("Cart").ordertotal = Session("Cart").ordertotal - rebate
                Else
                    sOrdrWarn = sOrdrWarn + " rebate too high -- not applied"
                End If
            End If
            Session("Cart") = oCart
            ssql = "execute spCreateOrder"
            cmdSave = New SqlCommand(ssql, conn)
            cmdSave.Parameters.AddWithValue("@username", username)
            Dim dt As New DataTable
            dt.Load(cmdSave.ExecuteReader)
            Dim ordrid As Integer = dt.Rows(0).Field(Of Integer)(0)
            For Each ltuple As Tuple(Of Integer, Decimal) In Session("Cart").orderdetail
                ssql = "insert into tblorderdetail(orderid, productid, orderquantity) select @orderid, @productid, @quantity"
                Dim cmd As New SqlCommand(ssql, conn)
                cmd.Parameters.AddWithValue("@orderid", ordrid)
                cmd.Parameters.AddWithValue("@productid", ltuple.Item1)
                cmd.Parameters.AddWithValue("@quantity", ltuple.Item2)
                cmd.ExecuteNonQuery()
            Next
            conn.Close()
        End If
        ResetForm()
    End Sub
    Private Sub ResetForm()
        For Each grw As DataGridItem In grdOrders.Items
            Dim txqt As TextBox = grw.FindControl("txtQty")
            txqt.Text = String.Empty
        Next
        txtDscnt.Text = String.Empty
        txtRebate.Text = String.Empty
    End Sub
    Protected Sub btnCancel_Click(ByVal sender As Object, e As System.EventArgs) Handles btnCancel.Click
        ResetForm()
    End Sub
    Protected Sub lnkLogout_click(ByVal sender As Object, e As System.EventArgs) Handles lnkLogout.Click
        Dim ssql As String = "update tblorders set orderdiscountpercent = @discnt, orderrebate = @rebate, orderpaiddate = getdate(), orderpaidamount = @payment where orderid = @ordrid"
        Dim conn As New SqlConnection(sConn)
        conn.Open()
        Dim cmd As New SqlCommand(ssql, conn)
        If Session("Cart") IsNot Nothing Then
            Dim oCart As clsCart = Session("Cart")
            cmd.Parameters.AddWithValue("@discnt", oCart.orderdisc)
            cmd.Parameters.AddWithValue("@rebate", oCart.orderRebate)
            cmd.Parameters.AddWithValue("@payment", oCart.ordertotal)
            cmd.Parameters.AddWithValue("@ordrid", oCart.orderid)
            Session("Cart") = Nothing
        End If
        conn.Close()
        Session("Customer") = Nothing
        Response.Redirect("login.aspx")
    End Sub
End Class