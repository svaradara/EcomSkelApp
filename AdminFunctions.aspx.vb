Public Class AdminFunctions
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub lnkProdAdm_click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lnkProdAdm.Click
        Response.Redirect("ManageProducts.aspx")
    End Sub
    Protected Sub lnkOrder_click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lnkOrder.Click
        Response.Redirect("PlaceOrder.aspx")
    End Sub

    Protected Sub lnkLogout_click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lnkLogout.Click
        Response.Redirect("login.aspx")
    End Sub
End Class