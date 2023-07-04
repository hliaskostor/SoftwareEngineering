<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RC.aspx.cs" Inherits="SoftwareEngineering.RC" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="width: 594px; height: 471px; margin-left: 0px; margin-top: 0px; margin-bottom: 0px;"; margin-top: 10px;>
    <form id="form1" runat="server" style="background: #FFFFFF url('Images/TOO_restaurant_Panoramique_vue_Paris_Seine_Tour_Eiffel_2.jpg') no-repeat fixed center; height: 740px; width: 1680px; margin-top: inherit; margin-bottom: inherit; margin-right: 0px;">
        <div>
            <br />
            <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" EnableModelValidation="True" Font-Bold="True" Font-Italic="False" Font-Names="Arial" GridLines="Vertical" Height="245px" Width="384px">
                <AlternatingRowStyle BackColor="#DCDCDC" />
                <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
            </asp:GridView>
            <br />
            <asp:Button ID="Button2" runat="server" BackColor="#9CB4CC" BorderStyle="Solid" Font-Bold="True" Font-Names="Arial" Font-Size="Medium" OnClick="Button2_Click" Text="Back" Width="145px" />
                &nbsp;</div>
    </form>
</body>
</html>