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
        <table style="width:100%;">
            <tr>
                <td>ID :</td>
                <td><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Name : </td>
                <td><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>address :</td>
                <td><asp:TextBox ID="TextBox3" runat="server" OnTextChanged="TextBox3_TextChanged"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>salary :</td>
                <td><asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="add" />
                </td>
                <td style="margin-left: 40px">
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="update" />
                </td>
            </tr>
            <tr>
                <td>
        <asp:Button ID="Button3" runat="server" Text="delete" />
                </td>
                <td style="margin-left: 40px">
        <asp:Button ID="Button4" runat="server" Text="display" />
                </td>
            </tr>
        </table>
        <br />
&nbsp;<br />
        <br />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
