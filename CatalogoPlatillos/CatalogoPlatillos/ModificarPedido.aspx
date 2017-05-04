<%@ Page Title="" Language="C#" MasterPageFile="~/MenuPrincipal.Master" AutoEventWireup="true" CodeBehind="ModificarPedido.aspx.cs" Inherits="CatalogoPlatillos.ModificarPedido" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    Modificar Pedido
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
        <tr>
            <td>
                <asp:Label ID="lbl_nombre" runat="server" Text="A nombre de:"></asp:Label>
            </td>
            <td>

            </td>
            <td>
                <asp:TextBox ID="TxtNombreCliente" runat="server" Width="264px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td><asp:Label ID="lbl_direccion" runat="server" Text="Direccion"></asp:Label></td>
            <td></td>
            <td><asp:TextBox ID="txtDireccion" runat="server" Width="421px"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lbl_platillos" runat="server" Text="Platillos:"></asp:Label>
            </td>
            <td></td>
            <td>
                 <asp:TextBox ID="txtCategoria" runat="server"></asp:TextBox>
            </td>
            <td> <asp:DropDownList ID="ddlPlatillo" runat="server" Visible="true"></asp:DropDownList></td>
            <td><asp:label ID="lbl_cantidad" runat="server" Text="Cantidad:"></asp:label></td>
            <td><asp:TextBox ID="txtCantidad" runat="server" Width="40px"></asp:TextBox></td>
        </tr>
          
        <tr>
            <td>
                <asp:Label ID="lbl_precio" runat="server" Text="Precio:"></asp:Label>
            </td>
            <td>

            </td>
            <td>
                <asp:TextBox ID="TxtPrecio" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lbl_descripcion" runat="server" Text="Descripcion:"></asp:Label>
            </td>
            <td>

            </td>
            <td>
                <asp:TextBox ID="TxtDescripcion" runat="server" Height="88px" Width="422px" TextMode="MultiLine"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>

            </td>
            <td>

            </td>
            <td>
                <asp:Button ID="btnGuardar" runat="server" Text="Modificar" OnClick="btnGuardar_Click" />
                <asp:Label ID="lbl_mensaje" runat="server" Text=""></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>
