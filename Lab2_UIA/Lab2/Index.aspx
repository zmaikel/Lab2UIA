<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Lab2.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Login</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label Text="Usuario" runat="server"></asp:Label>
            <br />
            <asp:TextBox ID="box1" runat="server"></asp:TextBox>
            <br />
            <asp:Label Text="Pass" runat="server"></asp:Label>
            <br />
            <asp:TextBox ID="box2" TextMode="Password" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID ="btn1" runat="server" Text="Entrar" OnClick="btn1_Click"/>  
            <br />
        </div>
    </form>
</body>
</html>
