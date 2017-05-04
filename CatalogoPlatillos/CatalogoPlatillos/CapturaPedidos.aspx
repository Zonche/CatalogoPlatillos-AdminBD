<%@ Page Title="" Language="C#" MasterPageFile="~/MenuPrincipal.Master" AutoEventWireup="true" CodeBehind="CapturaPedidos.aspx.cs" Inherits="CatalogoPlatillos.CapturaPedidos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    Captura de Pedidos
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
            <td>Fecha:</td>
            <td>
                <asp:Calendar ID="cld_date" runat="server"></asp:Calendar>
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
            <td> <asp:DropDownList ID="ddlPlatillo" runat="server" Visible="true" OnSelectedIndexChanged="ddlPlatillo_SelectedIndexChanged" OnLoad="ddlPlatillo_Load" Height="16px" Width="197px"></asp:DropDownList></td>
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
                <asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click" />
                <asp:Label ID="lbl_mensaje" runat="server" Text=""></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>
