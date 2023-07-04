<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Insert.aspx.cs" Inherits="SoftwareEngineering.Insert" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="width: 1335px; height: 640px; margin-left: 0px; margin-top: 0px; margin-bottom: 0px;"; margin-top: 10px;>
    <form id="form1" runat="server" style="background: #FFFFFF url('Images/TOO_restaurant_Panoramique_vue_Paris_Seine_Tour_Eiffel_2.jpg') no-repeat fixed center; height: 740px; width: 1680px; margin-top: inherit; margin-bottom: inherit; margin-right: 0px;">
        <div style="width: 978px; height: 223px; margin-left: 480px">
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <asp:Panel ID="Panel1" runat="server" BorderStyle="Solid" Font-Bold="True" Font-Names="Arial" Font-Size="Medium" Height="234px" Width="371px">
                <asp:Label ID="Insert4" runat="server" BackColor="#A2B7CC" Font-Bold="True" Font-Italic="False" Font-Names="Arial Black" Text="Insert a new Restaurant" BorderStyle="Solid" Font-Size="Medium"></asp:Label>
                <br />
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox2" runat="server" BackColor="#99B3CC" BorderStyle="Solid" Font-Bold="True" Font-Names="Arial" Font-Size="Medium" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button2" runat="server" BackColor="#9CB4CC" BorderStyle="Solid" Font-Bold="True" Font-Names="Arial" Font-Size="Medium" OnClick="Button2_Click" style="margin-right: 0px" Text="Back" Width="102px" />
                &nbsp;<asp:Button ID="Button3" runat="server" BackColor="#AABDCE" BorderStyle="Solid" Font-Bold="True" Font-Names="Arial" Font-Size="Medium" OnClick="Button3_Click" Text="Enter" />
                <br />
                <br />
                <br />
                <asp:Label ID="Label2" runat="server" BackColor="#A7BCCF" BorderStyle="Solid" Text="The insert was successfull" Visible="False"></asp:Label>
            </asp:Panel>
        </div>
    </form>
</body>
</html>
