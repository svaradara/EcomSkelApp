Imports System.Data.SqlClient
Public Class EditProducts
    Inherits System.Web.UI.Page
    Dim sConn As String = "Data Source=PRASANNASPC\SRINISQL;Initial Catalog=EcomSkel;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim conn As New SqlConnection(sConn)
        conn.Open()
        Dim ssql As String = "select productid, productcode from tblproducts order by productcode"
        Dim cmd As New SqlCommand(ssql, conn)
        Dim dtProds As New DataTable
        dtProds.Load(cmd.ExecuteReader)
        For Each drow As DataRow In dtProds.Rows
            Dim lstItm As New ListItem
            lstItm.Value = drow.Field(Of int)("productid")
            lstItm.Text = drow.Field(Of String)("productcode")
            ddlProdNo.Items.Add(lstItm)
        Next
        ddlProdNo.Focus()
        conn.Close()
    End Sub

    Protected Sub ddlProdNo_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlProdNo.SelectedIndexChanged
        Dim conn As New SqlConnection(sConn)
        Dim ssql As String = "select * from tblproducts where productid = @prid"
        conn.Open()
        Dim cmd As New SqlCommand(ssql, conn)
        cmd.Parameters.AddWithValue("@prid", ddlProdNo.SelectedValue)
        Dim dtProd As New DataTable
        dtProd.Load(cmd.ExecuteReader)
        Dim dr As DataRow = dtProd.Rows(0)
        txtProdPrice.Text = dr.Field(Of Decimal)("productprice")
        txtProdUnit.Text = dr.Field(Of String)("productunit")
        txtNewStock.Text = "0"
        txtNewStock.Focus()
    End Sub
    Protected Sub btnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim conn As New SqlConnection(sConn)
        Dim strError
        conn.Open()
        If Integer.Parse(ddlProdNo.SelectedValue) <> -1 Then
            Dim ssql As String = "spUpdProduct "
            Dim cmd As New SqlCommand(ssql, conn)
            cmd.Parameters.AddWithValue("@prid", Integer.Parse(ddlProdNo.SelectedValue))
            cmd.Parameters.AddWithValue("@newdesc", txtProdDesc.Text)
            cmd.Parameters.AddWithValue("@newprice", Decimal.Parse(txtProdPrice.Text))
            cmd.Parameters.AddWithValue("@newunit", txtProdUnit.Text)
            cmd.Parameters.AddWithValue("@restock", txtNewStock.Text)
            cmd.ExecuteNonQuery()
        Else
            strError = "Please Select a Product"
            ddlProdNo.Focus()
        End If
        conn.Close()

        For Each ctl As Control In Me.Controls
            If TypeOf (ctl) Is TextBox Then
                CType(ctl, TextBox).Text = String.Empty
            End If
        Next
        ddlProdNo.SelectedValue = "-1"
        ddlProdNo.Focus()
    End Sub
    Protected Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        For Each ctl As Control In Me.Controls
            If TypeOf (ctl) Is TextBox Then
                CType(ctl, TextBox).Text = String.Empty
            End If
        Next
        ddlProdNo.SelectedValue = "-1"
        ddlProdNo.Focus()
    End Sub
    Protected Sub lnkLogout_click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lnkLogout.Click
        Session("Customer") = Nothing
        Session("Cart") = Nothing
        Response.Redirect("login.aspx")
    End Sub

End Class