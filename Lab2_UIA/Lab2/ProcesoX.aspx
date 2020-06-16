<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProcesoX.aspx.cs" Inherits="Lab2.ProcesoX" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Proceso</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="UserName" Text="text" runat="server" />
            <br />
            <asp:TextBox ID="txtb1" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btncalct" Text="Multiplicar" runat="server" OnClick="btncalct_Click" />
            <br />
            <asp:TextBox ID="box2" runat="server"></asp:TextBox>
            <br />
            <br />

        </div>
    </form>
</body>
</html>
