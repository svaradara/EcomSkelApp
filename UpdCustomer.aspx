<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="UpdCustomer.aspx.vb" Inherits="EcomSkelApp.NewCustomer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Table runat="server">
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server" ColumnSpan="2" HorizontalAlign="Center" Text="Update Customer Info" Font-Size="X-Large" />
                </asp:TableRow>
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server" ColumnSpan="2" Text="&nbsp" />
                </asp:TableRow>
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server" Text="&nbsp" Font-Bold="true" />
                    <asp:TableCell runat="server" Visible="false"><asp:TextBox ID="txtUser" runat="server" MaxLength="30" Width="30" TabIndex="1"/></asp:TableCell>
                    <asp:TableCell runat="server" Text="Password:" Font-Bold="true" />
                    <asp:TableCell runat="server"><asp:TextBox ID="txtPass" Width="30" MaxLength="50" TextMode="Password" runat="server" TabIndex="2"/></asp:TableCell>
                </asp:TableRow>
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server" Text="Address:" />
                    <asp:TableCell runat="server" ColumnSpan="3">
                        <asp:TextBox runat="server" ID="txtAddrs" Width="90" MaxLength="150" TabIndex="3" />
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server" Text="Email:" />
                    <asp:TableCell runat="server">
                        <asp:textbox runat="server" Width="40" MaxLength="100" ID="txtEmail" TabIndex="4" />
                    </asp:TableCell>
                    <asp:TableCell runat="server" Text="Phone No:" />
                    <asp:TableCell runat="server">
                        <asp:TextBox runat="server" ID="txtPhone" TabIndex="5" Width="20" MaxLength="20" />
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server" HorizontalAlign="Center" ColumnSpan="4">
                        <asp:Button runat="server" ID="btnUpdUser" Text="Update Customer Info" BackColor="PowderBlue" ForeColor="White" />
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server" HorizontalAlign="Center" ColumnSpan="4">
                        <asp:LinkButton runat="server" Text="Logout" ID="lnkExitApp" />
                    </asp:TableCell>
                </asp:TableRow>
            </asp:Table>
        </div>
    </form>
</body>
</html>
