<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CrearUsuario.aspx.cs" Inherits="CapaCliente.Páginas.CrearUsuario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Ingrese los datos para la creacion de su usuario<br />
            <br />
            <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="cambiarCredenciales.aspx">Cambiar Credenciales</asp:HyperLink>
            <br />
            <br />
            Identificacion&nbsp;&nbsp;
            <asp:TextBox ID="txt_ID" runat="server" Width="169px" MaxLength="20"></asp:TextBox>
            <br />
            Nombre&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txt_Nombre" runat="server" Width="168px" MaxLength="20"></asp:TextBox>
            <br />
            Apellidos&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txt_Apellidos" runat="server" Width="168px" MaxLength="50"></asp:TextBox>
            <br />
            Contraseña&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblClave" runat="server"></asp:Label>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
           <div>
               <asp:Button ID="btnGuardar" runat="server" OnClick="btnGuardar_Click" Text="Guardar" style="width: 68px" />
        </div>
    </form>
</body>
</html>
