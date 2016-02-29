<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="main.aspx.cs" Inherits="Ejemplo_1_WebApp.main" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h3>Bienvenidos al Sistema Gestor de base de datos</h3>
        <h3>Crear una nueva base de datos</h3>
    </div>
        <div>
            <asp:Label Text="Nombre de la base de datos:" runat="server" />
            <asp:TextBox ID="txtbasedatos" runat="server" />
            <asp:Button Text="Crear" runat="server" OnClick="Unnamed2_Click" />
        </div>
    </form>
</body>
</html>
