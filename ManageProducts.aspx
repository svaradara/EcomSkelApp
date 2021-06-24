<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="ManageProducts.aspx.vb" Inherits="EcomSkelApp.ManageProducts" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Table runat="server" HorizontalAlign="Center">
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server" HorizontalAlign="Center" Text="Products Administration" Font-Bold="true" Font-Size="X-Large" />
                </asp:TableRow>
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server" Text="&nbsp" />
                </asp:TableRow>
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server" HorizontalAlign="Center">
                        <asp:LinkButton ID="lnkAddProd" runat="server" Text="Add Products" />
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server" HorizontalAlign="Center">
                        <asp:LinkButton ID="lnkUpdProd" runat="server" Text="Update Product Info" />
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server" Text="&nbsp"/>
                </asp:TableRow>
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server" HorizontalAlign="Center">
                        <asp:LinkButton ID="lnkLogout" runat="server" Text="Logout" />
                    </asp:TableCell>
                </asp:TableRow>
            </asp:Table>
        </div>
    </form>
</body>
</html>
