<%@ Page Title="" Language="C#" MasterPageFile="~/Abm.Master" AutoEventWireup="true" CodeBehind="ListadoAlumnos.aspx.cs" Inherits="AbmAlumnosWeb.ListadoAlumnos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Listado de Alumnos</h1>
    <h4>A través de la vista</h4>
    <asp:GridView CssClass="table table-hover table-bordered" runat="server"
        ID="grid_alumnos_vista"></asp:GridView>
    <h4>A través de una consulta</h4>
    <asp:GridView CssClass="table table-hover table-bordered" runat="server"
        ID="grid_alumnos_consulta"></asp:GridView>
</asp:Content>
