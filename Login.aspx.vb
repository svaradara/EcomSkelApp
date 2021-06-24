Imports System.Data
Imports System.Data.SqlClient
Public Class Login
    Inherits System.Web.UI.Page

    Dim sConn As String = "Data Source=PRASANNASPC\SRINISQL;Initial Catalog=EcomSkel;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub
    Private Sub ProcessLogin(ByVal userid As String, ByVal passwd As String)
        Dim ssql As String = "select * from tblcustomer where custusername=@AmUser and custpasswd=@passwd"
        Dim conn As New SqlConnection(sConn)
        conn.Open()
        Dim cmd As New SqlCommand(ssql, conn)
        cmd.Parameters.AddWithValue("@AmUser", userid)
        cmd.Parameters.AddWithValue("@passwd", passwd)
        Dim dt As New DataTable
        dt.Load(cmd.ExecuteReader)
        Dim cnt As Integer = dt.Rows.Count
        If cnt = 0 Then
            tcErr.Text = "Invalid username or password"
            tfrErr.Visible = True
        Else
            Dim oCustomer As New clsCustomer
            oCustomer.customerid = dt.Rows(0).Field(Of Integer)("customerid")
            oCustomer.custusername = userid
            oCustomer.custname = dt.Rows(0).Field(Of String)("custname")
            oCustomer.custaddress = dt.Rows(0).Field(Of String)("custaddress")
            oCustomer.custemail = dt.Rows(0).Field(Of String)("custemail")
            oCustomer.custphone = dt.Rows(0).Field(Of String)("custphoneno")
            oCustomer.custAdmin = dt.Rows(0).Field(Of Boolean)("custisadmin")
            Session("customer") = oCustomer
            If oCustomer.custAdmin Then
                Response.Redirect("AdminFunctions.aspx")
            Else
                Response.Redirect("PlaceOrder.aspx")
            End If
            If conn IsNot Nothing Then
                conn.Close()
            End If
        End If

    End Sub
    Protected Sub btnLogin_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        ProcessLogin(txtUsrNm.Text, txtPass.Text)
    End Sub
    Protected Sub lnkNewCustomer_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lnkNewCustomer.Click
        Response.Redirect("NewCustomer.aspx")
    End Sub
    Protected Sub lnkUpdCustomer_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lnkUpdCustomer.Click
        If String.IsNullOrEmpty(txtUsrNm.Text) Then
            tcErr.Text = "Please enter username"
            tfrErr.Visible = True
        Else
            Dim conn As New SqlConnection(sConn)
            conn.Open()
            Dim ssql As String = "select count(*) from tblcustomer where custusername = @userid"
            Dim cmd As New SqlCommand(ssql, conn)
            cmd.Parameters.AddWithValue("@userid", txtUsrNm.Text)
            Dim dt As New DataTable
            dt.Load(cmd.ExecuteReader)
            If dt.Rows(0).Field(Of Integer)(0) < 1 Then
                tcErr.Text = "Invalid username: " & txtUsrNm.Text
                tfrErr.Visible = True
            Else
                Dim oCustomer As clsCustomer
                If Session("Customer") IsNot Nothing Then
                    oCustomer = Session("Customer")
                Else
                    oCustomer = New clsCustomer
                End If
                oCustomer.custusername = txtUsrNm.Text
                Session("Customer") = oCustomer
                Response.Redirect("UpdCustomer.aspx")
                If conn IsNot Nothing Then
                    conn.Close()
                End If
            End If
        End If
    End Sub
End Class