<%@ Page Title="" Language="C#" MasterPageFile="~/Abm.Master" AutoEventWireup="true" CodeBehind="Destino.aspx.cs" Inherits="AbmAlumnosWeb.Destino" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Destino</h1>
    Nombre:<asp:Label ID="lb_nombre" runat="server"></asp:Label>
    <br />
    Apellido:<asp:Label ID="lb_apellido" runat="server"></asp:Label>


    <select name="combo_loco">
        <option value="1">Opcion Uno</option>
        <option value="2">Opcion Dos</option>
        <option value="3">Opcion Tres</option>
    </select>

 </asp:Content>
