<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Adopcion.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="LabelBienvenida" runat="server" />
            <asp:LinkButton ID="LinkCerrarSesion" runat="server" OnClick="LinkCerrarSesion_Click">Cerrar sesión</asp:LinkButton>
        <div>
            <asp:Button ID="Button1" runat="server" Text="Button" />
        </div>
        <p>
            <asp:Button ID="Button2" runat="server" Text="Button" />
        </p>
    </form>
</body>
</html>
