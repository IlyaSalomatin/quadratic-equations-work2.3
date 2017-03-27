<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="work2._3.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 52px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Panel ID="Panel1" runat="server" Height="298px" Width="565px">
            <asp:Label ID="Label1" runat="server" style ="color:green;" Text="Решаем квадратное уравнение:"></asp:Label>
            <br />
            <asp:Label ID="Label2" runat="server" Text="(приведите уравнение к виду :&quot;+/- ах^2+/-bx+/-c=0&quot; где а !=0)"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Height="30px" Text="+" Width="40px" OnClick="Button1_Click" />
            <asp:TextBox ID="TextBox1" runat="server" Height="20px" Width="40px">1</asp:TextBox>
            <asp:Button ID="Button2" runat="server" Height="30px" Text="x^2" Width="40px" />
            <asp:Button ID="Button5" runat="server" Height="30px" Text="+" Width="40px" OnClick="Button5_Click" />
            <asp:TextBox ID="TextBox3" runat="server" Height="20px" Width="40px">1</asp:TextBox>
            <asp:Button ID="Button3" runat="server" Height="30px" Text="x" Width="40px" />
            <asp:Button ID="Button4" runat="server" Height="30px" Text="+" Width="40px" OnClick="Button4_Click" />
            <asp:TextBox ID="TextBox4" runat="server" Height="20px" Width="41px">1</asp:TextBox>
            <asp:Label ID="Label3" runat="server" Text="=0"></asp:Label>
            &nbsp;
            <br />
            <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="Результат:" Width="135px" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button7" runat="server" OnClick="Button7_Click" Text="Сброс" Width="81px" />
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Text="x1="></asp:Label>
            &nbsp;
            <asp:Label ID="Label5" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label6" runat="server" Text="x2="></asp:Label>
            &nbsp;
            <asp:Label ID="Label7" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label8" style ="color:red;" runat="server"></asp:Label>
        </asp:Panel>
    </form>
</body>
</html>
