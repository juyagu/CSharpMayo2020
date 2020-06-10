<%@ Page Title="" Language="C#" MasterPageFile="~/Abm.Master" AutoEventWireup="true" CodeBehind="AdministracionCursos.aspx.cs" Inherits="AbmAlumnosWeb.AdministracionCursos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Administracion de cursos</h1>
    <div class="form-row align-items-center">
        <div class="col-auto">
            <asp:Label Text="Materia" runat="server" />
            <asp:DropDownList ID="DropMaterias" 
                CssClass="form-control" runat="server" />
        </div>
        <div class="col-auto">
            <asp:Label Text="Aula" runat="server" />
            <asp:DropDownList ID="DropAula" 
                CssClass="form-control" runat="server" />
        </div>
        <div class="col-auto">
            <asp:Label Text="Instructor" runat="server" />
            <asp:DropDownList ID="DropInstructor" 
                CssClass="form-control" runat="server" />
        </div>
        <div class="col-auto">
            <button class="btn btn-primary" id="btn_enviar" type="button">
                Enviar
            </button>
        </div>
    </div>
    <hr />
    <table class="table table-hover table-bordered">
        <thead>
            <tr>
                <th>#</th>
                <th>Materia</th>
                <th>Programa</th>
                <th>Aula</th>
                <th>Instructor</th>
            </tr>
        </thead>
        <tbody id="body_cursos">

        </tbody>
    </table>
    <script type="text/javascript" src="js/script.js"></script>
</asp:Content>
