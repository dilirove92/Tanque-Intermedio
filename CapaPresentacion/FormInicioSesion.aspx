<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FormInicioSesion.aspx.cs" Inherits="ProyectoTanqueIntermedioEpam.CapaPresentacion.FormInicioSesion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title></title>
    <style type="text/css">
        #form1
        {
            height: 651px;
            width: 1348px;
            top: 4px;
            left: 10px;
            margin-top: 0px;
            margin-bottom: 2px;
        }
        .nuevoEstilo1
        {
            background-image: url('ima/gris1.jpg');
        }
        .nuevoEstilo2
        {
            background-image: url('ima/pantalla.jpg');
        }
        .nuevoEstilo3
        {
            position: absolute;
            z-index: auto;
        }
        .nuevoEstilo4
        {
            position: absolute;
            z-index: auto;
        }
        .nuevoEstilo5
        {
            position: absolute;
            z-index: auto;
            top: 244px;
            left: 896px;
            width: 96px;
            font-family: Arial;
            font-size: smaller;
        }
        .nuevoEstilo6
        {
            position: absolute;
            z-index: auto;
        }
        .nuevoEstilo7
        {
            position: absolute;
            z-index: auto;
        }
        .nuevoEstilo8
        {
            position: absolute;
            z-index: auto;
        }
        .style2
        {
            position: absolute;
            z-index: auto;
            left: 974px;
            top: 254px;
            width: 145px;
            font-family: Arial;
            font-size: small;
        }
        .nuevoEstilo9
        {
            position: absolute;
            z-index: auto;
        }
        .style3
        {
            position: absolute;
            z-index: auto;
            left: 974px;
            top: 285px;
            width: 145px;
            font-family: Arial;
            font-size: small;
        }
        .nuevoEstilo10
        {
            position: absolute;
            z-index: auto;
        }
        .style5
        {
            position: absolute;
            z-index: auto;
            top: 218px;
            left: 870px;
            width: 266px;
        }
        .style6
        {
            position: absolute;
            z-index: auto;
            top: 190px;
            left: 847px;
            width: 201px;
        }
        .style7
        {
            background-image: url('ima/pantalla.jpg');
            text-align: right;
        }
        .style8
        {
            position: absolute;
            z-index: auto;
            left: 917px;
            top: 255px;
        }
        .nuevoEstilo11
        {
            position: absolute;
            z-index: auto;
        }
        .nuevoEstilo12
        {
            background-image: url('ima/celeste.jpg');
            position: absolute;
            z-index: auto;
        }
        .style10
        {
            background-image: url('ima/celeste.jpg');
            position: absolute;
            z-index: auto;
            left: 1043px;
            top: 354px;
            color: #FFFFFF;
            font-size: medium;
            font-family: "Times New Roman", Times, serif;
            font-weight: bold;
        }
        .nuevoEstilo13
        {
            position: absolute;
            z-index: auto;
        }
        .style11
        {
            position: absolute;
            z-index: auto;
            left: 201px;
            top: 580px;
            color: #CC3300;
            font-family: "Times New Roman", Times, serif;
            font-size: small;
            width: 139px;
        }
        .nuevoEstilo14
        {
            position: absolute;
            z-index: auto;
        }
        .style12
        {
            position: absolute;
            z-index: auto;
            left: 1053px;
            top: 173px;
            width: 41px;
            height: 44px;
        }
        .style13
        {
            position: absolute;
            z-index: auto;
            left: 896px;
            top: 286px;
        }
        .nuevoEstilo15
        {
            position: absolute;
            z-index: auto;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="style7" 
        
        
        
        style="height: 629px; width: 1010px; margin-left: 171px; margin-right: 0px; margin-top: 10px; background-image: url('ima/fondopantalla.jpg');">
        <asp:Label ID="Label1" runat="server" CssClass="style6" 
            style="font-family: 'Times New Roman', Times, serif; font-weight: 700; font-size: larger; text-align: center" 
            Text="Ingreso al Sistema"></asp:Label>
        <hr class="style5" />
        <asp:Label ID="Label3" runat="server" CssClass="style8" 
            style="font-family: Arial; font-size: small" Text="Usuario"></asp:Label>
        <asp:TextBox ID="txtUser" runat="server" CssClass="style2" height="16px" 
            width="145px"></asp:TextBox>
        <asp:TextBox ID="txtPass" runat="server" CssClass="style3" height="16px" 
            width="145px" TextMode="Password"></asp:TextBox>
        <strong>
        <asp:Button ID="btnSubmit" runat="server" CssClass="style10" Text="Ingresar" 
            onclick="btnSubmit_Click" />
        </strong>
        <asp:Label ID="Label5" runat="server" CssClass="style11" 
            Text="Tanque Intermedio "></asp:Label>
        <asp:Image ID="Image1" runat="server" CssClass="style12" 
            ImageUrl="~/ima/usuario.png" />
        <asp:Label ID="Label6" runat="server" CssClass="style13" 
            style="font-family: Arial; font-size: small" Text="Contraseña"></asp:Label>
    </div>

    <script type="text/javascript">

        function ValidText(e) {
            var tecla = document.all ? tecla = e.keyCode : tecla = e.which;
            return ((tecla > 64 && tecla < 91) || (tecla > 96 && tecla < 123) || (tecla > 159 || tecla < 164)
                    || tecla == 130 || tecla == 181 || tecla == 144 || tecla == 214 || tecla == 224 || tecla == 233
                    || tecla == 08 || tecla == 32);
        }                    

    </script>

</asp:Content>

