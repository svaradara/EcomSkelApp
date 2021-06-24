Public Class ManageProducts
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub
    Protected Sub lnkAddProd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lnkAddProd.Click
        Response.Redirect("addproducts.aspx")
    End Sub

    Protected Sub lnkUpdProd_click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lnkUpdProd.Click
        Response.Redirect("editproducts.aspx")
    End Sub
End Class