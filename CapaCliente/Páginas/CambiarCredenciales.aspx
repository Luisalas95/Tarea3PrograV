<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CambiarCredenciales.aspx.cs" Inherits="CapaCliente.Páginas.CambiarCredenciales" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="AdministracionProductos.aspx">Administrar Productos</asp:HyperLink>
        </div>
        <p>
            Identificación&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txt_ID" runat="server" Width="163px"></asp:TextBox>
        </p>
        <p>
            Nombre&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txt_Nombre" runat="server" Width="161px"></asp:TextBox>
        </p>
        <p>
            Apellidos&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txt_Apellidos" runat="server" Height="16px" Width="156px"></asp:TextBox>
        </p>
        <p>
            Contraseña&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txt_Clave" runat="server" Width="170px"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="btn_Cambiar" runat="server" OnClick="btn_Cambiar_Click" Text="Cambiar Credenciales" />
        </p>
    </form>
</body>
</html>
