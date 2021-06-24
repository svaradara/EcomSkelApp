Imports System.Data.SqlClient
Public Class AddProducts
    Inherits System.Web.UI.Page
    Dim sConn As String = "Data Source=PRASANNASPC\SRINISQL;Initial Catalog=EcomSkel;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        txtProdNo.Focus()
    End Sub

    Protected Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        For Each ctl As Control In Me.Controls
            If TypeOf (ctl) Is TextBox Then
                CType(ctl, TextBox).Text = String.Empty
            End If
        Next
        txtProdNo.Focus()
    End Sub

    Protected Sub btnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave.Click

        Dim conn As New SqlConnection(sConn)
        conn.Open()
        If Not String.IsNullOrEmpty(txtProdNo.Text) Then
            Dim ssql As String = "spAddProduct "
            Dim cmd As New SqlCommand(ssql, conn)
            cmd.Parameters.AddWithValue("@productcode", txtProdNo.Text)
            cmd.Parameters.AddWithValue("@productdesc", IIf(String.IsNullOrEmpty(txtProdDesc.Text), DBNull.Value, txtProdDesc.Text))
            cmd.Parameters.AddWithValue("@productprice", IIf(String.IsNullOrEmpty(txtProdPrice.Text), DBNull.Value, Decimal.Parse(txtProdPrice.Text)))
            cmd.Parameters.AddWithValue("@productunit", IIf(String.IsNullOrEmpty(txtProdUnit.Text), DBNull.Value, txtProdUnit.Text))
            cmd.Parameters.AddWithValue("@prodnewstock", IIf(String.IsNullOrEmpty(txtNewStock.Text), DBNull.Value, Decimal.Parse(txtNewStock.Text)))
            cmd.ExecuteNonQuery()
        Else
            tcErr.Text = "Product No cannot be empty"
            trErr.Visible = True
        End If
        conn.Close()

        For Each ctl As Control In Me.Controls
            If TypeOf (ctl) Is TextBox Then
                CType(ctl, TextBox).Text = String.Empty
            End If
        Next
        txtProdNo.Focus()
    End Sub

    Protected Sub lnkLogout_click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lnkLogout.Click
        Session("Customer") = Nothing
        Session("Cart") = Nothing
        Response.Redirect("login.aspx")
    End Sub
End Class