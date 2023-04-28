<%@ Page Title="Home Page" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="PracticaWeb1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <section class="Header">
        <div class="header" style="text-align: center">

            <img src="https://isfdyt93-bue.infd.edu.ar/sitio/wp-content/uploads/2023/04/logo-ISFT93-ANIIVERSARIO-modified.png" style="margin: auto" alt="Logo Instituto" />

        </div>
    </section>
    <hr />

    <div class="row">
        <div class="col-3"></div>
        <div class="col">
            <div class="mb-3">
                <label class="form-label">Direccion Email</label>
                <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="mb-3">
                <label class="form-label">Asunto</label>
                <asp:TextBox ID="txtAsunto" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="mb-3">
                <label class="form-label">Mensaje</label>
                <asp:TextBox ID="txtMensaje" runat="server" CssClass="form-control" TextMode="MultiLine"></asp:TextBox>
            </div>
          
        </div>
   <div class="col-3"></div>





    </div>






</asp:Content>
