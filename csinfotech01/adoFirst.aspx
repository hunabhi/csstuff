<%@ Page Language="C#" AutoEventWireup="true" CodeFile="adoFirst.aspx.cs" Inherits="adoFirst" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Employee Details<br />
        ID :<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;<br />
        Name<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        address :<asp:TextBox ID="TextBox3" runat="server" OnTextChanged="TextBox3_TextChanged"></asp:TextBox>
        <br />
        salary :<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="add" />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="update" />
        <asp:Button ID="Button3" runat="server" Text="delete" />
        <asp:Button ID="Button4" runat="server" Text="display" />
        <br />
    
    </div>
    </form>
</body>
</html>
