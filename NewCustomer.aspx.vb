Imports System.Data.SqlClient
Public Class NewCustomer
    Inherits System.Web.UI.Page
    Dim sConn As String = "Data Source=PRASANNASPC\SRINISQL;Initial Catalog=EcomSkel;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub
    Protected Sub btnNewUser_click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNewUser.Click
        Dim ssql As String = "spAddCustomer"
        Dim conn As New SqlConnection(sConn)
        conn.Open()
        Dim cmd As New SqlCommand(ssql, conn)
        cmd.Parameters.AddWithValue("@username", txtUser.Text)
        cmd.Parameters.AddWithValue("@password", txtPass.Text)
        cmd.Parameters.AddWithValue("@name", txtName.Text)
        cmd.Parameters.AddWithValue("@address", txtAddrs.Text)
        cmd.ExecuteNonQuery()
        Response.Redirect("login.aspx")
    End Sub
End Class