<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Rate.aspx.cs" Inherits="SoftwareEngineering.Rate" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="width: 751px; height: 736px; margin-left: 0px; margin-top: 0px; margin-bottom: 0px;"; margin-top: 10px;>
    <form id="form1" runat="server" style="background: #FFFFFF url('Images/TOO_restaurant_Panoramique_vue_Paris_Seine_Tour_Eiffel_2.jpg') no-repeat fixed center; height: 740px; width: 1680px; margin-top: inherit; margin-bottom: inherit; margin-right: 0px;">
        <div>
            <asp:Panel ID="Panel1" runat="server" BorderStyle="Solid" Height="516px" Width="788px">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label2" runat="server" BackColor="#A6B9CA" BorderColor="Black" BorderStyle="Solid" Font-Bold="True" Font-Names="Arial" Font-Size="Medium" Text="Rate the restaurant you want by choosing one from the list"></asp:Label>
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <br />
                &nbsp;
                <asp:Label ID="Label3" runat="server" BackColor="#B6C2D0" BorderColor="Black" BorderStyle="Solid" Font-Bold="True" Font-Names="Arial" Text="Name" Width="87px"></asp:Label>
                &nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="Name" runat="server" BackColor="#B3C0D0" BorderColor="Black" BorderStyle="Solid" Font-Bold="True" Font-Names="Arial" Font-Size="Medium" Height="26px" Width="204px"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <br />
                <br />
                &nbsp;<asp:Label ID="Label4" runat="server" BackColor="#A7B8CA" BorderStyle="Solid" Font-Bold="True" Font-Names="Arial" Text="Select restaurant" Width="176px"></asp:Label>
                &nbsp;<asp:DropDownList ID="List1" runat="server" BackColor="#B5C1CF" DataSourceID="SqlDataSource1" DataTextField="Name" DataValueField="Name" Font-Names="Arial" Font-Size="Medium" Height="23px" OnSelectedIndexChanged="List1_SelectedIndexChanged1" Font-Bold="True">
                </asp:DropDownList>
                <br />
                <br />
&nbsp;
                <asp:Label ID="Stars" runat="server" BackColor="#A2B3C7" BorderStyle="Solid" Font-Bold="True" Font-Names="Arial" Text="Stars" Width="56px"></asp:Label>
                &nbsp;&nbsp;&nbsp;
                <asp:DropDownList ID="StarsList" runat="server" BackColor="#A9BCCB" Font-Bold="True" Font-Names="Arial" Font-Size="Medium" Height="25px" OnSelectedIndexChanged="StarsList_SelectedIndexChanged" Width="102px">
                    <asp:ListItem>0</asp:ListItem>
                    <asp:ListItem>1</asp:ListItem>
                    <asp:ListItem>2</asp:ListItem>
                    <asp:ListItem>3</asp:ListItem>
                    <asp:ListItem>4</asp:ListItem>
                    <asp:ListItem>5</asp:ListItem>
                    <asp:ListItem>6</asp:ListItem>
                    <asp:ListItem>7</asp:ListItem>
                    <asp:ListItem>8</asp:ListItem>
                    <asp:ListItem>9</asp:ListItem>
                    <asp:ListItem>10</asp:ListItem>
                </asp:DropDownList>
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <br />
                <br />
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label7" runat="server" BackColor="#ADBED0" BorderStyle="Solid" Font-Bold="True" Font-Italic="False" Font-Names="Arial" Font-Size="Medium" Text="Comments"></asp:Label>
                &nbsp;
                <asp:TextBox ID="TextBox3" runat="server" BorderStyle="Solid" Height="86px" OnTextChanged="TextBox3_TextChanged" Width="363px"></asp:TextBox>
                &nbsp;&nbsp;
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label6" runat="server" BackColor="#B6C3D3" BorderStyle="Solid" Font-Bold="True" Font-Names="Arial" Text="Thank you for rate" Visible="False"></asp:Label>
                <br />
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button1" runat="server" BackColor="#ACBDCD" BorderColor="Black" BorderStyle="Solid" Font-Bold="True" Font-Names="Arial" Font-Size="Medium" OnClick="Button1_Click" Text="Submit" />
                <asp:Button ID="Button2" runat="server" BackColor="#9CB4CC" BorderStyle="Solid" Font-Bold="True" Font-Names="Arial" Font-Size="Medium" OnClick="Button2_Click" Text="Back" Width="171px" />
                <br />
                <br />
                <br />
                <br />
                <br />
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Connection %>" ProviderName="<%$ ConnectionStrings:Connection.ProviderName %>" SelectCommand="SELECT * FROM [Show]"></asp:SqlDataSource>
            </asp:Panel>
        </div>
    </form>
</body>
</html>
