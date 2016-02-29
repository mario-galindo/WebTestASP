<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="Ejemplo_1_WebApp._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Mi Primera Pagina ASP</title>

    <!--Dependencias para Boostrap-->
    <link href="Content/bootstrap.min.css" rel="stylesheet"/>
    <script src="//code.jquery.com/jquery-1.12.0.min.js"></script>
	<script src="Scripts/bootstrap.min.js"></script>
    <link href="Content/Style.css" rel="stylesheet" />


</head>
<body>
    <form id="form1" runat="server">
    <div class="container">

        <table>
            <tr>
                <th>Estudiante No.:</th>
                <td><asp:TextBox id="txtusuario" placeholder="Numero Estudiantes" CssClass="form-control" runat="server"></asp:TextBox></td> 
            </tr>
            <tr>
                <th>Estudiante Nombre:</th>
                <td><asp:TextBox id="txtpassword" placeholder="Nombre" CssClass="form-control" runat="server"></asp:TextBox></td>
            </tr>
            <!--<tr>
                <th>Estudiante Ciudad:</th>
                <td><asp:TextBox id="textboxt3" placeholder="Ciudad" CssClass="form-control" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <th>Estudiante Codigo:</th>
                <td><asp:TextBox id="textboxt4" placeholder="Codigo" CssClass="form-control" runat="server"></asp:TextBox></td>
            </tr>-->
            <tr>
                <th colspan="2">
                    <br />
                    <asp:Button ID="btnInsertar" CssClass="btn btn-danger" runat="server" Text="Insertar" OnClick="btnInsertar_Click" />
                    <!--<asp:Button ID="btnActualizar" CssClass="btn btn-default" runat="server" Text="Actualizar" />
                    <asp:Button ID="btnBorrar" CssClass="btn btn-danger" runat="server" Text="Borrar" />-->
                </th>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Label ID="lbMsg" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:GridView ID="gv" runat="server"></asp:GridView>
                </td>
            </tr>
            
        </table>
    </div>
    </form>


</body>
</html>
