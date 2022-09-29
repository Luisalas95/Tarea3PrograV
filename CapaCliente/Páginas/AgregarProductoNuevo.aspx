<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AgregarProductoNuevo.aspx.cs" Inherits="CapaCliente.Páginas.AgregarProductoNuevo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Ingreso Productos</title>

<link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-iYQeCzEYFbKjA/T2uDLTpkwGzCiq6soy8tYaI1GyVh/UjpbCx/TYkiZhlZB6+fzT" crossorigin="anonymous"/>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Ingrese los datos del nuevo Producto<br />
            <br />
              <label>Codigo Producto</label>
             <input type="number" id="txt_codigoproduct"  placeholder="Codigo Producto" runat="server" required="required"/>   
          <!--  <asp:TextBox  ID="txt_CodigoProducto" runat="server"  MaxLength="25" Width="163px"></asp:TextBox> --> 
     
            <br />
             <label>Nombre Producto</label>
           <input type="text" id="txt_Nomb"  placeholder="Nombre Producto" runat="server" required="required" maxlength="30"/>

            <br />
             <label>Existencias</label>
           <input type="number" id="txt_existencia"  placeholder="Existencias" runat="server" required="required"/>
            <br />
           <label>Ubicación Bodega</label>
           <input type="text" id="txt_UbicacionBodega"  placeholder="Ubicacion" runat="server" required="required" maxlength="20"/>

            <br />
            <br />
           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
             
            <asp:Button ID="btn_GuardarProduc" runat="server" Text="Guardar Producto" OnClick="btn_GuardarProduc_Click" />
        </div>
    </form>


</body>
</html>
