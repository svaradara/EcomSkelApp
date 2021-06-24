<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Login.aspx.vb" Inherits="EcomSkelApp.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Table runat="server" Width="60%" HorizontalAlign="Center">
                <asp:TableRow runat="server">
                    <asp:TableHeaderCell runat="server" ColumnSpan="2" Text="Demo ECommerce Site" Font-Size="X-Large" />
                </asp:TableRow>
                <asp:TableRow runat="server"><asp:TableHeaderCell ColumnSpan="2" Text="&nbsp" /></asp:TableRow>
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server" Text="User Name:" Font-Bold="true" />
                    <asp:TableCell runat="server">
                        <asp:TextBox runat="Server" MaxLength="30" TabIndex="1" ID="txtUsrNm"/>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server" Text="Password:" Font-Bold="true" />
                    <asp:TableCell runat="server">
                        <asp:TextBox ID="txtPass" runat="server" TextMode="Password" TabIndex="2" MaxLength="50" />
                    </asp:TableCell></asp:TableRow><asp:Tablerow runat="server">
                    <asp:TableCell runat="server" HorizontalAlign="Center" ColumnSpan="2">
                        <asp:Button runat="server" Text="Login" ID="btnLogin" ForeColor="White" BackColor="PowderBlue" />
                    </asp:TableCell></asp:Tablerow>
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server">
                        <asp:LinkButton runat="server" ID="lnkNewCustomer" Text="New User?  Create Login" />
                    </asp:TableCell>
                    <asp:TableCell runat="server">
                        <asp:LinkButton runat="server" ID="lnkUpdCustomer" Text="Forgot Password?  Reset" />
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableFooterRow runat="server" ID="tfrErr" Visible="false">
                    <asp:TableCell runat="server" ColumnSpan="4" HorizontalAlign="Center" id="tcErr" />
                </asp:TableFooterRow>
            </asp:Table>
        </div>
    </form>
</body>
</html>