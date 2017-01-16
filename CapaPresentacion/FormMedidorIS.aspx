<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FormMedidorIS.aspx.cs" Inherits="ProyectoTanqueIntermedioEpam.CapaPresentacion.FormMedidorIS" %>
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
        .nuevoEstilo9
        {
            position: absolute;
            z-index: auto;
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
            top: 180px;
            left: 396px;
            width: 773px;
            color: #CC3300;
        }
        .style6
        {
            position: absolute;
            z-index: auto;
            top: 73px;
            left: 603px;
            width: 201px;
            color: #CC3300;
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
        .nuevoEstilo13
        {
            position: absolute;
            z-index: auto;
        }
        .style11
        {
            position: absolute;
            z-index: auto;
            left: 202px;
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
            left: 1004px;
            top: 190px;
            width: 157px;
            font-family: "Times New Roman", Times, serif;
            font-size: small;
            color: #CC3300;
        }
        .nuevoEstilo15
        {
            position: absolute;
            z-index: auto;
        }
        .style13
        {
            position: absolute;
            z-index: auto;
            left: 400px;
            top: 243px;
            width: 760px;
            height: 320px;
            text-align: justify;
        }
        .nuevoEstilo16
        {
            position: absolute;
            z-index: auto;
        }
        .style14
        {
            position: absolute;
            z-index: auto;
            font-family: "Times New Roman", Times, serif;
            font-size: small;
            left: 990px;
            top: 223px;
            width: 172px;
        }
        .nuevoEstilo17
        {
            position: absolute;
            z-index: auto;
        }
        .style15
        {
            position: absolute;
            z-index: auto;
            left: 6px;
            top: 25px;
            width: 746px;
            color: #C0C0C0;
        }
        .nuevoEstilo18
        {
            position: absolute;
            z-index: auto;
        }
        .style16
        {
            position: absolute;
            z-index: auto;
            left: 6px;
            top: 2px;
            font-family: "Times New Roman", Times, serif;
            font-size: larger;
        }
        .nuevoEstilo19
        {
            position: absolute;
            z-index: auto;
        }
        .style17
        {
            position: absolute;
            z-index: auto;
            left: 175px;
            top: 45px;
            width: 408px;
            height: 261px;
            text-align: center;
        }
        .nuevoEstilo20
        {
            position: absolute;
            z-index: auto;
        }
        .nuevoEstilo21
        {
            position: absolute;
            z-index: auto;
        }
        .style19
        {
            position: absolute;
            z-index: auto;
            left: 127px;
            top: 38px;
            font-family: Arial;
            font-size: small;
        }
        .nuevoEstilo22
        {
            position: absolute;
            z-index: auto;
        }
        .style20
        {
            position: absolute;
            z-index: auto;
            left: 132px;
            top: 65px;
            font-family: Arial;
            font-size: small;
        }
        .nuevoEstilo23
        {
            position: absolute;
            z-index: auto;
        }
        .style21
        {
            position: absolute;
            z-index: auto;
            left: 171px;
            top: 93px;
            font-family: Arial;
            font-size: small;
        }
        .nuevoEstilo24
        {
            position: absolute;
            z-index: auto;
        }
        .style22
        {
            position: absolute;
            z-index: auto;
            left: 136px;
            top: 153px;
            font-family: Arial;
            font-size: small;
        }
        .nuevoEstilo25
        {
            position: absolute;
            z-index: auto;
        }
        .style23
        {
            position: absolute;
            z-index: auto;
            left: 96px;
            top: 196px;
            font-family: Arial;
            font-size: small;
        }
        .nuevoEstilo26
        {
            position: absolute;
            z-index: auto;
        }
        .nuevoEstilo27
        {
            position: absolute;
            z-index: auto;
        }
        .style25
        {
            position: absolute;
            z-index: auto;
            left: 222px;
            top: 37px;
            height: 16px;
            width: 145px;
            font-family: Arial;
            font-size: small;
        }
        .nuevoEstilo28
        {
            position: absolute;
            z-index: auto;
        }
        .style26
        {
            position: absolute;
            z-index: auto;
            left: 222px;
            top: 65px;
            font-family: Arial;
            font-size: small;
        }
        .nuevoEstilo29
        {
            position: absolute;
            z-index: auto;
        }
        .style27
        {
            position: absolute;
            z-index: auto;
            left: 222px;
            top: 93px;
            font-family: Arial;
            font-size: small;
        }
        .nuevoEstilo30
        {
            position: absolute;
            z-index: auto;
        }
        .style28
        {
            position: absolute;
            z-index: auto;
            left: 222px;
            top: 152px;
            font-family: Arial;
            font-size: small;
            height: 31px;
        }
        .nuevoEstilo31
        {
            position: absolute;
            z-index: auto;
        }
        .style29
        {
            position: absolute;
            z-index: auto;
            left: 222px;
            top: 196px;
            font-family: Arial;
            font-size: small;
        }
        .nuevoEstilo32
        {
            position: absolute;
            z-index: auto;
        }
        .nuevoEstilo33
        {
            background-image: url('ima/celeste.jpg');
            position: absolute;
            z-index: auto;
        }
        .style30
        {
            background-image: url('ima/celeste.jpg');
            position: absolute;
            z-index: auto;
            left: 281px;
            top: 220px;
            font-family: "Times New Roman", Times, serif;
            font-size: medium;
            font-weight: bold;
            color: #FFFFFF;
        }
        .nuevoEstilo34
        {
            position: absolute;
            z-index: auto;
        }
        .nuevoEstilo35
        {
            position: absolute;
            z-index: auto;
        }
        .style31
        {
            background-image: url('ima/pantalla.jpg');
            text-align: right;
        }
        .nuevoEstilo36
        {
            position: absolute;
            z-index: auto;
        }
        .style32
        {
            position: absolute;
            z-index: auto;
            left: 223px;
            top: 122px;
            width: 117px;
            right: 68px;
        }
        .style33
        {
            position: absolute;
            z-index: auto;
            left: 116px;
            top: 122px;
            font-family: Arial;
            font-size: small;
        }
        .nuevoEstilo37
        {
            position: absolute;
            z-index: auto;
        }
        .style34
        {
            position: absolute;
            z-index: auto;
            left: 350px;
            top: 121px;
        }
        .nuevoEstilo38
        {
            position: absolute;
            z-index: auto;
        }
        .style35
        {
            position: absolute;
            z-index: auto;
            left: 222px;
            top: 10px;
            width: 140px;
        }
        .nuevoEstilo39
        {
            position: absolute;
            z-index: auto;
        }
        .style36
        {
            position: absolute;
            z-index: auto;
            left: 39px;
            top: 11px;
            font-family: Arial;
            font-size: small;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="style31" 
        
        
        
        
        style="height: 629px; width: 1010px; margin-left: 171px; margin-right: 0px; margin-top: 10px; background-image: url('ima/fondopantalla.jpg');">
        <asp:Label ID="Label1" runat="server" CssClass="style6" 
            style="font-family: 'Times New Roman', Times, serif; font-weight: 700; font-size: larger; text-align: center" 
            Text="Datos del Medidor"></asp:Label>
        <hr class="style5" />
        <asp:Label ID="Label5" runat="server" CssClass="style11" 
            Text="Tanque Intermedio"></asp:Label>
        <asp:Label ID="lblTipoUser" runat="server" CssClass="style12" 
            Text="|  Administrador o Usuario"></asp:Label>
        <div class="style13" style="border: thin groove #C0C0C0">
            <hr class="style15" />
            <strong>
            <asp:Label ID="Label8" runat="server" CssClass="style16" 
                Text="Ingreso de Datos del Medidor"></asp:Label>
            </strong>
            <div class="style17" style="border: thin groove #CC3300">
                <asp:Label ID="Label11" runat="server" CssClass="style20" Text="Lectura Final"></asp:Label>
                <asp:Label ID="Label10" runat="server" CssClass="style19" 
                    Text="Lectura Inicial"></asp:Label>
                <asp:Label ID="Label14" runat="server" CssClass="style23" 
                    Text="Nombre de Usuario"></asp:Label>
                <asp:Label ID="Label12" runat="server" CssClass="style21" Text="Fecha"></asp:Label>
                <asp:Label ID="Label13" runat="server" CssClass="style33" Text="MC Adicionales"></asp:Label>
                <asp:TextBox ID="txtLecturaIni" runat="server" CssClass="style25" height="16px" 
                    width="145px"></asp:TextBox>
                <asp:TextBox ID="txtLecturaFin" runat="server" CssClass="style26" height="16px" 
                    width="145px"></asp:TextBox>
                <asp:ImageButton ID="btnMCAdicionales" runat="server" CssClass="style34" 
                    onclick="btnMCAdicionales_Click" ImageUrl="~/ima/mass.png" 
                    style="width: 16px" />
                <asp:TextBox ID="txtFecha" runat="server" CssClass="style27" height="16px" 
                    width="145px"></asp:TextBox>
                <asp:TextBox ID="txtUsuario" runat="server" CssClass="style29" height="16px" 
                    width="145px"></asp:TextBox>
                <asp:TextBox ID="txtObservacion" runat="server" CssClass="style28" 
                    width="145px"></asp:TextBox>
                <strong>
                <asp:Button ID="btnGuardar" runat="server" CssClass="style30" Text="Guardar" 
                    onclick="btnGuardar_Click" />
                <asp:TextBox ID="txtMCAdicionales" runat="server" CssClass="style32" 
                    Height="16px"></asp:TextBox>
                </strong>
                <asp:Label ID="Label15" runat="server" CssClass="style22" Text="Observación"></asp:Label>
                <asp:TextBox ID="txtLFinalAnterior" runat="server" CssClass="style35" 
                    Height="16px" Width="145px"></asp:TextBox>
                <asp:Label ID="Label16" runat="server" CssClass="style36" 
                    Text="Lectura Final del Dia Anterior"></asp:Label>
            </div>
        </div>
        <asp:Label ID="lblFecha" runat="server" CssClass="style14" 
            Text="Domingo, 3 de Febrero del 2013"></asp:Label>
    </div>

    <script type="text/javascript">

        function ValidInt(e) {
            var tecla = document.all ? tecla = e.keyCode : tecla = e.which;
            return ((tecla > 47 && tecla < 58) || tecla == 08);
        }

        function ValidFecha(e) {
            var tecla = document.all ? tecla = e.keyCode : tecla = e.which;
            return ((tecla > 47 && tecla < 58) || tecla == 45 || tecla == 08);
        }        

        function ValidText(e) {
            var tecla = document.all ? tecla = e.keyCode : tecla = e.which;
            return ((tecla > 64 && tecla < 91) || (tecla > 96 && tecla < 123) || (tecla > 159 || tecla < 164)
                    || tecla == 130 || tecla == 181 || tecla == 144 || tecla == 214 || tecla == 224 || tecla == 233
                    || tecla == 08 || tecla == 32);
        } 
         
    </script> 

</asp:Content>

