<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="AddProducts.aspx.vb" Inherits="EcomSkelApp.AddProducts" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Table runat="server" HorizontalAlign="Center">
                <asp:TableRow runat="server" HorizontalAlign="Center">
                    <asp:TableHeaderCell runat="server" Text="Product No" Font-Bold="true" />
                    <asp:TableHeaderCell runat="server" Text="Product Description" Font-Bold="true"/>
                    <asp:TableHeaderCell runat="server" Text="Product Unit Price" Font-Bold="true" />
                    <asp:TableHeaderCell runat="server" Text="Product Unit" Font-Bold="true" />
                    <asp:TableHeaderCell runat="server" Text="Initial Stock" Font-Bold="true" />
                </asp:TableRow>
                <asp:TableRow runat="server" HorizontalAlign="Center">
                    <asp:TableCell runat="server">
                        <asp:TextBox runat="server" ID="txtProdNo" Width="100" MaxLength="20" TabIndex="1" />
                    </asp:TableCell>
                    <asp:TableCell runat="server">
                        <asp:TextBox runat="server" ID="txtProdDesc" Width="500" MaxLength="1000" TabIndex="2"/>
                    </asp:TableCell>
                    <asp:TableCell runat="server">
                        <asp:TextBox runat="server" ID="txtProdPrice" Width="100" TextMode="Number" MaxLength="18" TabIndex="3" />
                    </asp:TableCell>
                    <asp:TableCell runat="server">
                        <asp:TextBox runat="server" ID="txtProdUnit" Width="100" MaxLength="50" TabIndex="4" />
                    </asp:TableCell>
                    <asp:TableCell runat="server">
                        <asp:TextBox runat="server" ID="txtNewStock" Width="100" MaxLength="12" TextMode="Number" TabIndex="5" />
                    </asp:TableCell>
                </asp:TableRow>
            </asp:table>
            <br /><br />
            <asp:Table runat="server" HorizontalAlign="Center">
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server" HorizontalAlign="Right">
                        <asp:Button runat="server" ID="btnSave" CommandName="Submit" Text="Save" />
                    </asp:TableCell>
                    <asp:TableCell runat="server" Text="&nbsp" />
                    <asp:TableCell runat="server" HorizontalAlign="Left">
                        <asp:Button runat="server" ID="btnCancel" CommandName="Cancel" Text="Cancel" />
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server" Text="&nbsp" />
                </asp:TableRow>
            </asp:Table>
            <asp:Table runat="server" HorizontalAlign="Center">
                <asp:TableRow runat="server" ID="trErr" Visible="false" HorizontalAlign="Center">
                    <asp:TableCell runat="server" ColumnSpan="2" ID="tcErr" />
                </asp:TableRow>
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server" HorizontalAlign="Center">
                        <asp:LinkButton runat="server" ID="lnkLogout" Text="Logout" />
                    </asp:TableCell>
                </asp:TableRow>
            </asp:Table>
        </div>
    </form>
</body>
</html>
