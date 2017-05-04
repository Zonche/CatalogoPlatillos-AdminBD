<%@ Page Title="" Language="C#" MasterPageFile="~/MenuPrincipal.Master" AutoEventWireup="true" CodeBehind="ListaPedidos.aspx.cs" Inherits="CatalogoPlatillos.ListaPedidos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    Pedidos
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <table>
            <tr>
                <td><asp:GridView ID="gvPedidos" runat="server"></asp:GridView></td>
            </tr>
        </table>
    </div>
</asp:Content>
