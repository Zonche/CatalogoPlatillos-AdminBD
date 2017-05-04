<%@ Page Title="" Language="C#" MasterPageFile="~/MenuPrincipal.Master" AutoEventWireup="true" CodeBehind="CapturaPlatillo.aspx.cs" Inherits="CatalogoPlatillos.CapturaPlatillo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    Captura Platillos
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
        <tr>
            <td>
                <asp:Label ID="lbl_nombre" runat="server" Text="Nombre del Platillo:"></asp:Label>
            </td>
            <td>

            </td>
            <td>
                <asp:TextBox ID="TxtNombrePlatillo" runat="server"></asp:TextBox>
            </td>
        </tr>

        <tr>
            <td>
                <asp:Label ID="lbl_categoria" runat="server" Text="Categoria:"></asp:Label>
            </td>
            <td>

            </td>
            <td>
                 <asp:DropDownList ID="ddlcategoria" runat="server" Visible = "true">
                     <asp:ListItem Text="Desayuno" Value="Desayuno"></asp:ListItem>
                     <asp:ListItem Text="Comida" Value="Comida"></asp:ListItem>
                     <asp:ListItem Text="Cena" Value="Cena"></asp:ListItem>
                     <asp:ListItem Text="Postres" Value="Postres"></asp:ListItem>
                     <asp:ListItem Text="Bebidas" Value="Bebidas"></asp:ListItem>
                 </asp:DropDownList>
                </td>
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
                <asp:TextBox ID="TxtDescripcion" runat="server" Height="88px" Width="154px" TextMode="MultiLine"></asp:TextBox>
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
