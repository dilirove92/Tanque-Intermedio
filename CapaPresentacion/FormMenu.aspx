<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FormMenu.aspx.cs" Inherits="ProyectoTanqueIntermedioEpam.CapaPresentacion.FormMenu" %>
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
            left: 598px;
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
            right: 692px;
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
            left: 1003px;
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
            left: 399px;
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
            left: 988px;
            top: 223px;
            width: 172px;
        }
        .nuevoEstilo17
        {
            position: absolute;
            z-index: auto;
        }
        .nuevoEstilo18
        {
            position: absolute;
            z-index: auto;
        }
        .nuevoEstilo19
        {
            position: absolute;
            z-index: auto;
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
        .nuevoEstilo22
        {
            position: absolute;
            z-index: auto;
        }
        .nuevoEstilo23
        {
            position: absolute;
            z-index: auto;
        }
        .nuevoEstilo24
        {
            position: absolute;
            z-index: auto;
        }
        .nuevoEstilo25
        {
            position: absolute;
            z-index: auto;
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
        .nuevoEstilo28
        {
            position: absolute;
            z-index: auto;
        }
        .nuevoEstilo29
        {
            position: absolute;
            z-index: auto;
        }
        .nuevoEstilo30
        {
            position: absolute;
            z-index: auto;
        }
        .nuevoEstilo31
        {
            position: absolute;
            z-index: auto;
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
        .nuevoEstilo36
        {
            position: absolute;
            z-index: auto;
        }
        .nuevoEstilo37
        {
            position: absolute;
            z-index: auto;
        }
        .nuevoEstilo38
        {
            position: absolute;
            z-index: auto;
        }
        .nuevoEstilo39
        {
            position: absolute;
            z-index: auto;
        }
        .style20
        {
            position: absolute;
            z-index: auto;
            left: 27px;
            top: 25px;
            width: 120px;
            height: 120px;
            right: 613px;
        }
        .nuevoEstilo40
        {
            position: absolute;
            z-index: auto;
        }
        .style21
        {
            position: absolute;
            z-index: auto;
            left: 173px;
            top: 25px;
            height: 120px;
            width: 120px;
        }
        .nuevoEstilo41
        {
            position: absolute;
            z-index: auto;
        }
        .style22
        {
            position: absolute;
            z-index: auto;
            left: 321px;
            top: 25px;
            right: 319px;
        }
        .nuevoEstilo42
        {
            position: absolute;
            z-index: auto;
        }
        .style23
        {
            position: absolute;
            z-index: auto;
            left: 468px;
            top: 25px;
        }
        .nuevoEstilo43
        {
            position: absolute;
            z-index: auto;
        }
        .style24
        {
            position: absolute;
            z-index: auto;
            left: 611px;
            top: 25px;
        }
        .nuevoEstilo44
        {
            position: absolute;
            z-index: auto;
        }
        .style25
        {
            position: absolute;
            z-index: auto;
            left: 103px;
            top: 168px;
            right: 537px;
        }
        .nuevoEstilo45
        {
            position: absolute;
            z-index: auto;
        }
        .style26
        {
            position: absolute;
            z-index: auto;
            left: 250px;
            top: 168px;
        }
        .nuevoEstilo46
        {
            position: absolute;
            z-index: auto;
        }
        .style27
        {
            position: absolute;
            z-index: auto;
            left: 395px;
            top: 168px;
        }
        .nuevoEstilo47
        {
            position: absolute;
            z-index: auto;
        }
        .style28
        {
            position: absolute;
            z-index: auto;
            left: 537px;
            top: 168px;
        }
        .nuevoEstilo48
        {
            position: absolute;
            z-index: auto;
        }
        .style29
        {
            position: absolute;
            z-index: auto;
            font-family: "Times New Roman", Times, serif;
            font-size: small;
            color: #FFFFFF;
            left: 908px;
            top: 32px;
            width: 159px;
        }
        .nuevoEstilo49
        {
            position: absolute;
            z-index: auto;
        }
        .style30
        {
            position: absolute;
            z-index: auto;
            left: 1063px;
            top: 32px;
            width: 94px;
            font-size: small;
            font-family: "Times New Roman", Times, serif;
            color: #FFFFFF;
            height: 15px;
        }
        .nuevoEstilo50
        {
            background-image: url('ima/celeste.jpg');
            border-style: outset;
            border-width: medium;
            border-top-color: #C0C0C0;
            position: absolute;
            z-index: auto;
        }
        .style31
        {
            border-top: medium outset #C0C0C0;
            background-image: url('ima/celeste.jpg');
            position: absolute;
            z-index: auto;
            left: 199px;
            top: 243px;
            width: 193px;
            font-family: "Times New Roman", Times, serif;
            font-size: medium;
            color: #FFFFFF;
            font-weight: bold;
            border-left-style: outset;
            border-left-width: medium;
            border-right-style: outset;
            border-right-width: medium;
            border-bottom-style: outset;
            border-bottom-width: medium;
        }
    .style32
    {
        background-image: url('ima/pantalla.jpg');
        text-align: right;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="style32" 
        
        
        
        
    style="height: 629px; width: 1010px; margin-left: 171px; margin-right: 0px; margin-top: 10px; background-image: url('ima/fondopantalla.jpg');">
        <asp:Label ID="Label1" runat="server" CssClass="style6" 
            style="font-family: 'Times New Roman', Times, serif; font-weight: 700; font-size: larger; text-align: center" 
            Text="Menú"></asp:Label>
        <hr class="style5" />
        <asp:Label ID="Label5" runat="server" CssClass="style11" 
            Text="Tanque Intermedio "></asp:Label>
        <asp:Label ID="lblTipoUser" runat="server" CssClass="style12" 
            Text="|  Administrador o Usuario"></asp:Label>
        <div class="style13" style="border: thin groove #C0C0C0">
            <asp:ImageButton ID="ImageMedidor" runat="server" CssClass="style23" 
                Height="120px" ImageUrl="~/ima/iMedidor.jpg" Width="120px" 
                onclick="ImageMedidor_Click" />
            <asp:ImageButton ID="ImageTanquero" runat="server" CssClass="style28" 
                Height="120px" ImageUrl="~/ima/iTanquero.jpg" Width="120px" 
                onclick="ImageTanquero_Click" />
            <asp:ImageButton ID="ImageDetalleFactura" runat="server" CssClass="style20" 
                ImageUrl="~/ima/iDetalleFactura.jpg" onclick="ImageDetalleFactura_Click" />
            <asp:ImageButton ID="ImageGuiaRemision" runat="server" CssClass="style21" 
                ImageUrl="~/ima/iGuiaRemision.jpg" onclick="ImageGuiaRemision_Click" />
            <asp:ImageButton ID="ImageReportes" runat="server" CssClass="style22" 
                Height="120px" ImageUrl="~/ima/iReportes.jpg" Width="120px" 
                onclick="ImageReportes_Click" />
            <asp:ImageButton ID="ImageMetrosCubicosDespachados" runat="server" CssClass="style24" 
                Height="120px" ImageUrl="~/ima/iMetrosCubicos.jpg" Width="120px" 
                onclick="ImageMetrosCubicosDespachados_Click" />
            <asp:ImageButton ID="ImageUsuarios" runat="server" CssClass="style25" 
                Height="120px" ImageUrl="~/ima/iUsuarios.jpg" Width="120px" 
                onclick="ImageUsuarios_Click" />
            <asp:ImageButton ID="ImageTransportita" runat="server" CssClass="style26" 
                Height="120px" ImageUrl="~/ima/iTransporte.jpg" Width="120px" 
                onclick="ImageTransportita_Click" />
            <asp:ImageButton ID="ImageClientes" runat="server" CssClass="style27" 
                Height="120px" ImageUrl="~/ima/iClientes.jpg" Width="120px" 
                onclick="ImageClientes_Click" />
        </div>
        <asp:Label ID="lblFecha" runat="server" CssClass="style14" 
            Text="Domingo, 3 de Febrero del 2013"></asp:Label>
        <asp:Label ID="lblUser" runat="server" CssClass="style29" 
            Text="Bienvenid@:  NombreUser  |  "></asp:Label>
        <asp:HyperLink ID="HyperLink1" runat="server" CssClass="style30"  onClick = "HyperLink1_Click"
            NavigateUrl="~/FormMedidorIS.aspx" onunload="HyperLink1_Click">Cerrar Sesión</asp:HyperLink>
        <strong>
        <asp:Button ID="btnGenerarGuiaRemision" runat="server" CssClass="style31" 
            onclick="btnGenerarGuiaRemision_Click" Text="Generar Guía Remisión" />
        </strong>
    </div>
</asp:Content>

