<%@ Page Title="" Language="C#" MasterPageFile="~/Abm.Master" AutoEventWireup="true" CodeBehind="Buttons.aspx.cs" Inherits="AbmAlumnosWeb.Buttons" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <button id="boton_html" class="btn btn-success mt-5" onclick="btn_loco()">Boton HTML</button>
        <asp:Button ID="btn_asp" runat="server" CssClass="btn btn-outline-info mt-5 ml-3" Text="Boton ASP" OnClick="Boton_Loco_Presionado" />
        <asp:Label Text="" CssClass="mt-5 ml-3" ID="mensaje_boton" ForeColor="Red" runat="server" OnInit="mensaje_boton_DataBinding" />
        <asp:DropDownList runat="server" CssClass="form-control" ID="dropLoco" onchange="combo()">
            <asp:ListItem Value="1" Text="Opcion 1" />
            <asp:ListItem Value="2" Text="Opcion 2" />
        </asp:DropDownList>
    </div>
    <div class="row">
        <asp:HyperLink ID="HyperLinkCursos" 
                            CssClass="btn btn-danger mt-3" runat="server"
                            NavigateUrl="~/AdministracionCursos.aspx"
                             >Administración de Cursos</asp:HyperLink>
        <a href="ListadoAlumnos.aspx">Ir a Alumnos</a>
    </div>
    <script src="js/script.js"></script>
</asp:Content>
