<%@ Page Title="" Language="C#" MasterPageFile="~/Abm.Master" AutoEventWireup="true" CodeBehind="Origen.aspx.cs" Inherits="AbmAlumnosWeb.Origen" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Formulario</h1>
    <div class="row">
        <div class="form-group col-4">
            <label for="txt_nombre">Nombre:</label>
            <asp:TextBox runat="server" ID="txt_nombre" CssClass="form-control" />
         </div>
        <div class="form-group col-4">
            <label for="txt_apellido">Apellido:</label>
            <asp:TextBox runat="server" ID="txt_apellido" CssClass="form-control" />
         </div>
    </div>
    <div class="row">
        <asp:Button ID="btn_post" Text="Post" runat="server" PostBackUrl="~/Destino.aspx" CssClass="btn btn-primary" />
        <asp:Button ID="btn_get" Text="GET" runat="server" CssClass="btn btn-secondary" OnClick="btn_get_Click" />
    </div>
</asp:Content>
