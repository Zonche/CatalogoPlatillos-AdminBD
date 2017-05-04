<%@ Page Title="" Language="C#" MasterPageFile="~/MenuPrincipal.Master" AutoEventWireup="true" CodeBehind="ModificarPlatillo.aspx.cs" Inherits="CatalogoPlatillos.ModificarPlatillo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    Modificar Personas
<style type="text/css">
    .auto-style1 {
        width: 5px;
    }
</style>
<style type="text/css">
    .auto-style1 {
        width: 111px;
    }
    .auto-style2 {
        width: 274px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
        <tr>
            <td>
                <asp:Label ID="lbl_nombre" runat="server" Text="Nombre del Platillo:"></asp:Label>
            </td>
            <td class="auto-style2">

                <asp:TextBox ID="TxtNombrePlatillo" runat="server"></asp:TextBox>

            </td>
            <td class="auto-style1">
                &nbsp;</td>
        </tr>

        <tr>
            <td>
                <asp:Label ID="lbl_categoria" runat="server" Text="Categoria:"></asp:Label>
            </td>
            <td class="auto-style2">

                 <asp:DropDownList ID="ddlcategoria" runat="server" Visible = "true">
                     <asp:ListItem Text="Desayuno" Value="Desayuno"></asp:ListItem>
                     <asp:ListItem Text="Comida" Value="Comida"></asp:ListItem>
                     <asp:ListItem Text="Cena" Value="Cena"></asp:ListItem>
                     <asp:ListItem Text="Postres" Value="Postres"></asp:ListItem>
                     <asp:ListItem Text="Bebidas" Value="Bebidas"></asp:ListItem>
                 </asp:DropDownList>

            </td>
            <td class="auto-style1">
                 &nbsp;</td>
        </tr>
          
        <tr>
            <td>
                <asp:Label ID="lbl_precio" runat="server" Text="Precio:"></asp:Label>
            </td>
            <td class="auto-style2">

                <asp:TextBox ID="TxtPrecio" runat="server"></asp:TextBox>

            </td>
            <td class="auto-style1">
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lbl_descripcion" runat="server" Text="Descripcion:"></asp:Label>
            </td>
            <td class="auto-style2">
                <asp:TextBox ID="TxtDescripcion" runat="server" Height="150px" Width="264px" TextMode="MultiLine" ForeColor="#00FF99" MaxLength="100"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>

            </td>
            <td class="auto-style2">

                <asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click" />
                <asp:Button ID="btnBorrar" runat="server"  OnClick="btnBorrar_Click" Text="Borrar Platillo" />

            </td>
            <td class="auto-style1">
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>
