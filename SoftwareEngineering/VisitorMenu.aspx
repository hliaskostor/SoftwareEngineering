<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VisitorMenu.aspx.cs" Inherits="SoftwareEngineering.VisitorMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>

<body style="width: 594px; height: 471px; margin-left: 0px; margin-top: 0px; margin-bottom: 0px;"; margin-top: 10px;>
    <form id="form1" runat="server" style="background: #FFFFFF url('Images/TOO_restaurant_Panoramique_vue_Paris_Seine_Tour_Eiffel_2.jpg') no-repeat fixed center; height: 740px; width: 1680px; margin-top: inherit; margin-bottom: inherit; margin-right: 0px;">
        <asp:Panel ID="Panel1" runat="server" BorderStyle="Solid" Font-Bold="True" Font-Names="Arial" Height="373px" Width="520px">
            <asp:Button ID="RankButton" runat="server" Text="View rank of restaurants" BackColor="#9EB4C9" BorderStyle="Solid" Font-Bold="True" Font-Names="Arial" Height="83px" OnClick="Button1_Click" Width="246px" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Back" runat="server" BackColor="#9DB3CB" BorderStyle="Solid" Font-Bold="True" Font-Names="Arial" OnClick="LogOut_Click1" Text="Back" Width="118px" />
            <br />
            <br />
            <asp:Button ID="RateButton" runat="server" BackColor="#9EB4CC" BorderStyle="Solid" Font-Bold="True" Font-Names="Arial" Height="83px" OnClick="RateButton_Click" Text="Rate a restaurant" Width="246px" />
            <br />
            <br />
            <asp:Button ID="rcButton" runat="server" BackColor="#9CB2CA" BorderStyle="Solid" Font-Bold="True" Font-Names="Arial" Height="83px" Text="View rate and comments" Width="246px" OnClick="rcButton_Click" />
        </asp:Panel>
    </form>
</body>
</html>
