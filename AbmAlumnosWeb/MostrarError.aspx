<%@ Page Title="" Language="C#" MasterPageFile="~/Abm.Master" AutoEventWireup="true" CodeBehind="MostrarError.aspx.cs" Inherits="AbmAlumnosWeb.MostrarError" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Se ha producido un error</h1>
    <asp:Label ID="lbMensaje" runat="server"></asp:Label>
    <br />
    <asp:Button CssClass="btn btn-danger" ID="btnVolver" runat="server"
        OnClick="btnVolver_Click" Text="Volver" />
</asp:Content>
