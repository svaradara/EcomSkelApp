<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="AdminFunctions.aspx.vb" Inherits="EcomSkelApp.AdminFunctions" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:HiddenField runat="server" ID="fldUser" />
            <asp:Table runat="server" HorizontalAlign="Center">
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server" Text="Administrative" HorizontalAlign="Center" Font-Bold="true" Font-Size="X-Large" />
                </asp:TableRow>
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server" Text="&nbsp" />
                </asp:TableRow>
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server" HorizontalAlign="Center">
                        <asp:LinkButton runat="server" ID="lnkProdAdm" text="Administer Products" />
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server" Text="&nbsp" />
                </asp:TableRow>
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server" HorizontalAlign="Center">
                        <asp:LinkButton runat="server" ID="lnkOrder" Text="Place Order"/>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:tablerow runat="server">
                    <asp:TableCell runat="server" Text="&nbsp" />
                </asp:tablerow>
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server">
                        <asp:LinkButton runat="server" ID="lnkLogout" Text="logout" />
                    </asp:TableCell>
                </asp:TableRow>
            </asp:Table>
        </div>
    </form>
</body>
</html>
