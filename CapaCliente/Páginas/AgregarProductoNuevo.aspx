<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AgregarProductoNuevo.aspx.cs" Inherits="CapaCliente.Páginas.AgregarProductoNuevo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Ingrese los datos del nuevo Producto<br />
            <br />
            Codigo Producto&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txt_CodigoProducto" runat="server" MaxLength="25" Width="163px"></asp:TextBox>
            <br />
            Nombre&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txt_Nombre" runat="server" MaxLength="30" Width="157px"></asp:TextBox>
&nbsp;&nbsp;
            <br />
            Existencias&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txt_Existencias" runat="server" MaxLength="12" Width="158px"></asp:TextBox>
            <br />
            Ubicación (Bodega)&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txt_Ubicacion" runat="server" MaxLength="20" Width="155px"></asp:TextBox>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btn_GuardarProducto" runat="server" Text="Guardar Producto" />
        </div>
    </form>
</body>
</html>
