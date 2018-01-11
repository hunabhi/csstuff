<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default3.aspx.cs" Inherits="Default3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width: 100%; border: 1px solid black;">
                

                    <script>
                        var first = 0;
                        var second = 1;
                        var fib;
                        document.write("<tr style='width: 100%; border: 1px solid black;'> <td style='border:1px solid black;'>" + first + "</td>");
                        document.write("<td style='border:1px solid black;'>" + second + "</td>");

                        for (var i = 3; i < 53-1; i++) {
                            fib = first + second;

                            document.write("<td style='border:1px solid black;'>" + fib + "</td>");
                            if (i % 3 == 0) {
                                document.write("</tr> <tr style='width:100%;border:1px solid black;'>");
                            }
                            first = second;
                            second = fib;
                        }
                        document.write("</tr>");
                    </script>

            </table>
        </div>
    </form>
</body>
</html>
