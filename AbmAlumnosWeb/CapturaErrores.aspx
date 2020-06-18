<%@ Page Title="" Language="C#" MasterPageFile="~/Abm.Master" AutoEventWireup="true" CodeBehind="CapturaErrores.aspx.cs" Inherits="AbmAlumnosWeb.CapturaErrores" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Administración de errores</h1>
    <div class="row">
        <asp:Button CssClass="btn btn-primary" runat="server" ID="btn_sincaptura" 
            Text="Error a nivel de página sin capturar" OnClick="btn_sincaptura_Click" />
    </div>
    <div class="row mt-5">
        <asp:Button CssClass="btn btn-success" runat="server" ID="btn_concaptura" 
            Text="Error a nivel de página capturado con TRY CATCH" OnClick="btn_concaptura_Click" />
    </div>
    <div class="row mt-5">
        <asp:Button CssClass="btn btn-secondary" runat="server" ID="btn_global" 
            Text="Error de IIS(pagina no encontrada)" OnClick="btn_global_Click" />
    </div>
</asp:Content>
