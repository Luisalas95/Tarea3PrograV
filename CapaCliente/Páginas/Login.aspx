<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="CapaCliente.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Incio de Sesion&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:HyperLink ID="lbl_UsuarioNuevo" runat="server" NavigateUrl="CrearUsuario.aspx">Crear Usuario Nuevo </asp:HyperLink>

        </div>
        <p>
            Usuario&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txt_Usuario" runat="server"  Width="179px" Height="19px" MaxLength="20" OnTextChanged="txt_Usuario_TextChanged"></asp:TextBox>
        </p>
        <p>
            Clave&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txt_Clave" runat="server" Height="19px" Width="180px" MaxLength="20" OnTextChanged="txt_Clave_TextChanged" TextMode="Password"></asp:TextBox>
        </p>
        <div style="margin-left: 80px">
            <asp:Button ID="btn_IniciarSesion" runat="server" OnClick="btn_IniciarSesion_Click" Text="Iniciar Sesion" />
        </div>
        <p style="margin-left: 80px">
            &nbsp;</p>
    </form>
</body>
</html>
