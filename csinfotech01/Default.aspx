<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" lang="en">
<head runat="server">
    <title>title of new web application</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="XX-Large" Text="Label"></asp:Label>
    
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Welcome" />
        <br />
        <br />
        <br />
        <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
&nbsp;(optr)&nbsp;
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
&nbsp;=
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Button2" runat="server" Font-Bold="False" Font-Italic="True" Font-Size="XX-Large" OnClick="MethodForButtons" Text="Add" />
&nbsp;<asp:Button ID="Button3" runat="server" Font-Bold="False" Font-Italic="True" Font-Size="XX-Large" OnClick="MethodForButtons" Text="Subtract" />
&nbsp;<asp:Button ID="Button4" runat="server" Font-Bold="False" Font-Italic="True" Font-Size="XX-Large" OnClick="MethodForButtons" Text="Multiply" />
&nbsp;<asp:Button ID="Button5" runat="server" Font-Bold="False" Font-Italic="True" Font-Size="XX-Large" OnClick="MethodForButtons" Text="Divide" />
&nbsp;<asp:Button ID="Button6" runat="server" Font-Bold="False" Font-Italic="True" Font-Size="XX-Large" OnClick="MethodForButtons" Text="Modulo" />
    
        <br />
        <br />
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Default2.aspx">HyperLink to page fibonacci</asp:HyperLink>
        <br />
        <br />
        <asp:Button ID="Button7" runat="server" OnClick="Button7_Click" Text="Button" />
    
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/Default3.aspx">click to see a mathematical series</asp:HyperLink>
    
    </div>
    </form>
</body>
</html>
