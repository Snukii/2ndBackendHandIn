<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="_2ndHandIn.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Customers</title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ListBox ID="ListBoxCustomers" runat="server" Height="315px" Width="435px"></asp:ListBox>
        <br />
        <br />
        <asp:Button ID="ButtonAll" runat="server" OnClick="ButtonAll_Click" Text="Show all customers" />
        <br />
        <br />
        Show customers from:<br />
        <br />
        <asp:Button ID="ButtonJylland" runat="server" OnClick="ButtonJylland_Click" Text="Jylland" />
        <br />
        <br />
        <asp:Button ID="ButtonFyn" runat="server" OnClick="ButtonFyn_Click" Text="Fyn" />
        <br />
        <br />
        <asp:Button ID="ButtonSjælland" runat="server" OnClick="ButtonSjælland_Click" Text="Sjælland" />
        <br />
        <br />
        <br />
        Create new customer:<br />
        <asp:TextBox ID="TextBoxName" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:Label ID="LabelName" runat="server" Text="Name"></asp:Label>
        <br />
        <asp:TextBox ID="TextBoxAge" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:Label ID="LabelAge" runat="server" Text="Age"></asp:Label>
        <br />
        <asp:TextBox ID="TextBoxZipcode" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:Label ID="LabelNameZipcode" runat="server" Text="Zipcode"></asp:Label>
        <br />
        <asp:TextBox ID="TextBoxPassword" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:Label ID="LabelNamePassword" runat="server" Text="Password"></asp:Label>
        <br />
        <br />
        <asp:Button ID="ButtonCreate" runat="server" OnClick="ButtonCreate_Click" Text="Create" />
        <br />
        <div>
        </div>
    </form>
</body>
</html>
