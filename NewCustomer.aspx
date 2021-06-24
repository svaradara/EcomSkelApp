<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="NewCustomer.aspx.vb" Inherits="EcomSkelApp.NewCustomer" %>

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
                    <asp:TableCell runat="server" ColumnSpan="6" HorizontalAlign="Center" Text="New Customer" Font-Size="X-Large" />
                </asp:TableRow>
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server" ColumnSpan="6" Text="&nbsp" />
                </asp:TableRow>
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server" Text="UserName:" Font-Bold="true" />
                    <asp:TableCell runat="server">
                        <asp:TextBox ID="txtUser" runat="server" MaxLength="30" Width="30" TabIndex="1"/>
                    </asp:TableCell>
                    <asp:TableCell runat="server" Text="Password:" Font-Bold="true" />
                    <asp:TableCell runat="server">
                        <asp:TextBox ID="txtPass" Width="30" MaxLength="50" TextMode="Password" runat="server" TabIndex="2"/>
                    </asp:TableCell>
                    <asp:TableCell runat="server" Text="Customer Name:" Font-Bold="true" />
                    <asp:TableCell runat="server">
                        <asp:TextBox runat="server" Id="txtName" Width="50" MaxLength="100" TabIndex="3"/>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server" Text="Address:" Font-Bold="true" />
                    <asp:TableCell runat="server" ColumnSpan="5">
                        <asp:TextBox runat="server" ID="txtAddrs" Width="90" MaxLength="150" TabIndex="4" />
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server" Text="&nbsp" />
                    <asp:TableCell runat="server" Text="Email:" Font-Bold="true"/>
                    <asp:TableCell runat="server">
                        <asp:textbox runat="server" Width="40" MaxLength="100" ID="txtEmail" TabIndex="5" />
                    </asp:TableCell>
                    <asp:TableCell runat="server" Text="Phone No:" Font-bold="true"/>
                    <asp:TableCell runat="server">
                        <asp:TextBox runat="server" ID="txtPhone" TabIndex="6" Width="20" MaxLength="20" />
                    </asp:TableCell>
                    <asp:TableCell runat="server" Text="&nbsp" />
                </asp:TableRow>
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server" HorizontalAlign="Center" ColumnSpan="6">
                        <asp:Button runat="server" ID="btnNewUser" Text="Create Customer" BackColor="PowderBlue" TabIndex="7" ForeColor="White" />
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server" HorizontalAlign="Center" ColumnSpan="6">
                        <asp:LinkButton runat="server" Text="Logout" ID="lnkExitApp" />
                    </asp:TableCell>
                </asp:TableRow>
                <asp:tablefooterrow runat="server" ID="tfrError" Visible="false">
                    <asp:TableCell runat="server" ColumnSpan="6" HorizontalAlign="Center" id="tclError" Text="Entered username already exists, please type another" />
                </asp:tablefooterrow>
            </asp:Table>
        </div>
    </form>
</body>
</html>
