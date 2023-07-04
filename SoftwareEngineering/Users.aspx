<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Users.aspx.cs" Inherits="SoftwareEngineering.Users" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="width: 834px; height: 684px; margin-left: 0px; margin-top: 0px; margin-bottom: 0px;"; margin-top: 10px;>
    <form id="form1" runat="server" style="background: #FFFFFF url('Images/TOO_restaurant_Panoramique_vue_Paris_Seine_Tour_Eiffel_2.jpg') no-repeat fixed center; height: 740px; width: 1680px; margin-top: inherit; margin-bottom: inherit; margin-right: 0px;">
        <div>
            <br />
            <asp:Button ID="Button2" runat="server" BackColor="#9CB4CC" BorderStyle="Solid" Font-Bold="True" Font-Names="Arial" Font-Size="Medium" OnClick="Button2_Click" Text="Back" Width="220px" />
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" DataKeyNames="Name" DataSourceID="SqlDataSource1" EnableModelValidation="True" Font-Bold="True" Font-Names="Arial" GridLines="Vertical">
                <AlternatingRowStyle BackColor="#DCDCDC" />
                <Columns>
                    <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                    <asp:BoundField DataField="Name" HeaderText="Name" ReadOnly="True" SortExpression="Name" />
                    <asp:BoundField DataField="Username" HeaderText="Username" SortExpression="Username" />
                    <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
                    <asp:BoundField DataField="Password" HeaderText="Password" SortExpression="Password" />
                </Columns>
                <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Connection %>" DeleteCommand="DELETE FROM [Register] WHERE [Name] = ?" InsertCommand="INSERT INTO [Register] ([Name], [Username], [Email], [Password]) VALUES (?, ?, ?, ?)" ProviderName="<%$ ConnectionStrings:Connection.ProviderName %>" SelectCommand="SELECT * FROM [Register]" UpdateCommand="UPDATE [Register] SET [Username] = ?, [Email] = ?, [Password] = ? WHERE [Name] = ?">
                <DeleteParameters>
                    <asp:Parameter Name="Name" Type="String" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="Name" Type="String" />
                    <asp:Parameter Name="Username" Type="String" />
                    <asp:Parameter Name="Email" Type="String" />
                    <asp:Parameter Name="Password" Type="String" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:Parameter Name="Username" Type="String" />
                    <asp:Parameter Name="Email" Type="String" />
                    <asp:Parameter Name="Password" Type="String" />
                    <asp:Parameter Name="Name" Type="String" />
                </UpdateParameters>
            </asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
