<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="PlaceOrder.aspx.vb" Inherits="EcomSkelApp.PlaceOrder" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DataGrid runat="server" ID="grdOrders" HorizontalAlign="Center">
                <Columns>
                    <asp:BoundColumn DataField="productno" HeaderText="Product No" />
                    <asp:BoundColumn DataField="productdesc" HeaderText="Product Description" />
                    <asp:BoundColumn DataField="productprice" HeaderText="Product Price (per unit)" />
                    <asp:BoundColumn DataField="productunit"  HeaderText="Unit"/>
                    <asp:TemplateColumn HeaderText="Quantity">
                        <EditItemTemplate>
                            <asp:TextBox runat="server" ID="txtQty" TextMode="Number" MaxLength="8" />
                        </EditItemTemplate>
                    </asp:TemplateColumn>
                    <asp:TemplateColumn Visible="false" HeaderText="Enough On Hand (Y/N)">
                        <EditItemTemplate>
                            <asp:CheckBox runat="server" ID="chkEnuf" Checked="true" />
                        </EditItemTemplate>
                    </asp:TemplateColumn>
                </Columns>
            </asp:DataGrid>
            <br /><br />
            <asp:Table runat="server" HorizontalAlign="Center">
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server" Text="Discount Percent:"/>
                    <asp:TableCell runat="server">
                        <asp:TextBox runat="server" ID="txtDscnt" TextMode="Number" MaxLength="7" Width="20"/>
                    </asp:TableCell>
                    <asp:TableCell runat="server" Text="Rebate:" />
                    <asp:TableCell runat="server">
                        <asp:TextBox runat="server" ID="txtRebate" TextMode="Number" MaxLength="18" Width="40" />
                    </asp:TableCell>
                </asp:TableRow>
            </asp:Table>
            <br />
            <asp:Table runat="server" ID="tblErr" Visible="false" HorizontalAlign="Center">
                <asp:TableRow runat="server">
                    <asp:TableCell HorizontalAlign="Center" ID="tcErr" />
                </asp:TableRow>
            </asp:Table>
            <asp:table runat="server" HorizontalAlign="Center">
                <asp:TableRow runat="server">
                    <asp:tablecell runat="server" HorizontalAlign="Center">
                        <asp:Button ID="btnPlaceOrder" runat="server" CommandName="Submit" Text="Submit" />
                    </asp:tablecell>
                    <asp:TableCell runat="server" HorizontalAlign="Center">
                        <asp:Button runat="server" ID="btnCancel" CommandName="Cancel" Text="Cancel" />
                    </asp:TableCell>
                </asp:TableRow>
            </asp:table>
            <br /><br />
            <asp:Table runat="server" HorizontalAlign="Center">
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server" Text="Order Discount Percent:"/>
                    <asp:TableCell runat="server">
                        <asp:TextBox runat="server" ID=""
                    </asp:TableCell>
                </asp:TableRow>
            </asp:Table>
            <br /><br /><br />
            <asp:Table runat="server" HorizontalAlign="Center">
                <asp:tablerow runat="server">
                    <asp:TableCell runat="server" HorizontalAlign="Center">
                        <asp:LinkButton runat="server" ID="lnkLogout" Text="Logout" />
                    </asp:TableCell>
                </asp:tablerow>
            </asp:Table>
        </div>
    </form>
</body>
</html>
