<%@ Page Title="" Language="C#" MasterPageFile="~/MenuPrincipal.Master" AutoEventWireup="true" CodeBehind="ConsultarPlatillos.aspx.cs" Inherits="CatalogoPlatillos.ConsultarPlatillos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    Consulta Personas
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:DropDownList ID="ddlCategoria" runat="server" OnSelectedIndexChanged="ddlCategoria_SelectedIndexChanged" AutoPostBack ="True" Height="29px" Width="148px" DataTextField="NumPlatillos" DataValueField="NumPlatillos"></asp:DropDownList>
    <asp:GridView ID="gvPlatillos" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4" Height="174px" Width="979px" style="margin-top: 19px">
        <Columns>
        <asp:BoundField DataField="Nombre_Platillo" HeaderText="Nombre del Producto" />
        <asp:BoundField DataField="Categoria" HeaderText="Categoria" />
        <asp:BoundField DataField="Precio" HeaderText="Precio" />
        <asp:BoundField DataField="Descripcion" HeaderText="Descripcion" />
        <asp:HyperLinkField DataTextField="Liga" DataNavigateUrlFields="Liga" />
        </Columns>

        <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
        <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
        <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
        <RowStyle BackColor="White" ForeColor="#330099" />
        <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
        <SortedAscendingCellStyle BackColor="#FEFCEB" />
        <SortedAscendingHeaderStyle BackColor="#AF0101" />
        <SortedDescendingCellStyle BackColor="#F6F0C0" />
        <SortedDescendingHeaderStyle BackColor="#7E0000" />

    </asp:GridView>
</asp:Content>
