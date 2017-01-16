<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FormGestionPermisosUsuario.aspx.cs" Inherits="ProyectoTanqueIntermedioEpam.CapaPresentacion.FormGestionPermisosUsuario" %>
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
            left: 395px;
            width: 773px;
            color: #CC3300;
        }
        .style6
        {
            position: absolute;
            z-index: auto;
            top: 73px;
            left: 603px;
            width: 226px;
            color: #CC3300;
        }
        .style7
        {
            background-image: url('ima/pantalla.jpg');
            text-align: right;
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
        .nuevoEstilo14
        {
            position: absolute;
            z-index: auto;
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
            left: 195px;
            top: 61px;
            width: 388px;
            height: 228px;
            text-align: left;
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
            background-image: url('ima/celeste.jpg');
            border: medium outset #808080;
            position: absolute;
            z-index: auto;
        }
        .nuevoEstilo35
        {
            background-image: url('ima/celeste.jpg');
            border: medium outset #999999;
            position: absolute;
            z-index: auto;
        }
        .nuevoEstilo36
        {
            background-image: url('ima/celeste.jpg');
            border: medium outset #C0C0C0;
            position: absolute;
            z-index: auto;
        }
        .style30
        {
            background-image: url('ima/celeste.jpg');
            border: medium outset #C0C0C0;
            position: absolute;
            z-index: auto;
            left: 199px;
            top: 276px;
            font-family: "Times New Roman", Times, serif;
            font-size: medium;
            font-weight: bold;
            color: #FFFFFF;
        }
        .nuevoEstilo37
        {
            background-image: url('ima/celeste.jpg');
            border: medium outset #C0C0C0;
            position: absolute;
            z-index: auto;
        }
        .style31
        {
            background-image: url('ima/celeste.jpg');
            border: medium outset #C0C0C0;
            position: absolute;
            z-index: auto;
            left: 199px;
            top: 309px;
            font-family: "Times New Roman", Times, serif;
            font-size: medium;
            color: #FFFFFF;
            font-weight: bold;
        }
        .style33
        {
            background-image: url('ima/celeste.jpg');
            border: medium outset #C0C0C0;
            position: absolute;
            z-index: auto;
            left: 199px;
            top: 375px;
            font-family: "Times New Roman", Times, serif;
            font-size: medium;
            color: #FFFFFF;
            font-weight: bold;
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
        .style35
        {
            position: absolute;
            z-index: auto;
            left: 57px;
            top: 23px;
            height: 19px;
            font-family: Arial;
            font-size: small;
        }
        .nuevoEstilo40
        {
            position: absolute;
            z-index: auto;
        }
        .style36
        {
            position: absolute;
            z-index: auto;
            left: 106px;
            top: 22px;
            width: 235px;
            height: -5px;
        }
        .style114
        {
            position: absolute;
            z-index: auto;
            left: 121px;
            top: 55px;
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
        .nuevoEstilo41
        {
            position: absolute;
            z-index: auto;
        }
        .style118
        {
            position: absolute;
            z-index: auto;
            left: 1075px;
            top: 31px;
            width: 80px;
            font-size: small;
            font-family: "Times New Roman", Times, serif;
            color: #FFFFFF;
        }
        .nuevoEstilo42
        {
            position: absolute;
            z-index: auto;
        }
        .nuevoEstilo43
        {
            background-image: url('ima/celeste.jpg');
            position: absolute;
            z-index: auto;
            border: medium outset #C0C0C0;
        }
        .style119
        {
            background-image: url('ima/celeste.jpg');
            position: absolute;
            z-index: auto;
            border: medium outset #C0C0C0;
            left: 199px;
            top: 243px;
            font-family: "Times New Roman", Times, serif;
            font-size: medium;
            font-weight: bold;
            color: #FFFFFF;
        }
        .nuevoEstilo44
        {
            border: medium outset #C0C0C0;
            background-image: url('ima/celeste.jpg');
            position: absolute;
            z-index: auto;
        }
        .style120
        {
            background-image: url('ima/celeste.jpg');
            border: medium outset #C0C0C0;
            position: absolute;
            z-index: auto;
            left: 199px;
            top: 342px;
            font-family: "Times New Roman", Times, serif;
            font-size: medium;
            color: #FFFFFF;
            font-weight: bold;
        }
        .nuevoEstilo45
        {
            position: absolute;
            z-index: auto;
        }
        .style121
        {
            position: absolute;
            z-index: auto;
            left: 146px;
            top: 111px;
        }
        .nuevoEstilo46
        {
            position: absolute;
            z-index: auto;
        }
        .style122
        {
            position: absolute;
            z-index: auto;
            left: 146px;
            top: 140px;
        }
        .nuevoEstilo47
        {
            position: absolute;
            z-index: auto;
        }
        .style123
        {
            position: absolute;
            z-index: auto;
            left: 146px;
            top: 169px;
        }
        .nuevoEstilo48
        {
            position: absolute;
            z-index: auto;
        }
        .style124
        {
            position: absolute;
            z-index: auto;
            left: 343px;
            top: 262px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="style7" 
        
        
        
        style="height: 629px; width: 1010px; margin-left: 171px; margin-right: 0px; margin-top: 10px; background-image: url('ima/fondopantalla.jpg');">
        <asp:Label ID="Label1" runat="server" CssClass="style6" 
            style="font-family: 'Times New Roman', Times, serif; font-weight: 700; font-size: larger; text-align: center" 
            Text="Gestión de Usuarios"></asp:Label>
        <hr class="style5" />
        <div class="style13" style="border: thin groove #C0C0C0">
            <hr class="style15" />
            <strong>
            <asp:Label ID="Label8" runat="server" CssClass="style16" 
                Text="Gestión de Usuarios"></asp:Label>
            </strong>
            <div class="style17" style="border: thin groove #CC3300">
                <asp:Label ID="Label15" runat="server" CssClass="style35" Text="Tablas"></asp:Label>
                <asp:DropDownList ID="cbxTablas" runat="server" CssClass="style36">
                    <asp:ListItem>Cliente</asp:ListItem>
                    <asp:ListItem>Detalle Factura</asp:ListItem>
                    <asp:ListItem>Guia Remision</asp:ListItem>
                    <asp:ListItem>Guia Remision General</asp:ListItem>
                    <asp:ListItem>Medidor</asp:ListItem>
                    <asp:ListItem>Metros Cubicos Despachados</asp:ListItem>
                    <asp:ListItem>Reportes</asp:ListItem>
                    <asp:ListItem>Tanquero</asp:ListItem>
                    <asp:ListItem>Transportista</asp:ListItem>
                    <asp:ListItem>Usuario</asp:ListItem>
                </asp:DropDownList>
                </strong>
                <strong>
                <asp:RadioButtonList ID="radios" runat="server" CssClass="style114">
                    <asp:ListItem>Sin acceso</asp:ListItem>
                    <asp:ListItem>Permitir acceso</asp:ListItem>
                </asp:RadioButtonList>
                </strong></asp:Panel>
                <asp:CheckBox ID="CheckEliminar" runat="server" CssClass="style123" 
                    Text="Eliminar" />
                <asp:CheckBox ID="CheckModificar" runat="server" CssClass="style122" 
                    Text="Modificar" />
                <asp:CheckBox ID="CheckGuardar" runat="server" CssClass="style121" 
                    Text="Guardar" />
            </div>
            <asp:CheckBox ID="CheckImprimir" runat="server" CssClass="style124" 
                Text="Imprimir" />
        </div>
        <strong>
        <asp:Button ID="btnGuardar" runat="server" CssClass="style30" height="33px" 
            Text="Guardar" width="193px" onclick="btnBuscar_Click" />
        <asp:Button ID="btnModificar" runat="server" CssClass="style31" height="33px" 
            Text="Modificar" width="193px" onclick="btnModificar_Click" />
        <asp:Button ID="btnSalir" runat="server" CssClass="style33" height="33px" 
            Text="Salir" width="193px" onclick="btnSalir_Click" />
        </strong>
        <asp:Label ID="Label5" runat="server" CssClass="style11" 
            Text="Tanque Intermedio "></asp:Label>
        <asp:Label ID="lblTipoUser" runat="server" CssClass="style12" 
            Text="|  Administrador o Usuario"></asp:Label>
        <asp:Label ID="lblFecha" runat="server" CssClass="style14" 
            Text="Domingo, 3 de Febrero del 2013"></asp:Label>
        <asp:Label ID="lblUser" runat="server" CssClass="style29" 
            Text="Bienvenid@:  NombreUser  |  "></asp:Label>
        <asp:HyperLink ID="HyperLink2" runat="server" CssClass="style118" 
            NavigateUrl="~/FormMedidorIS.aspx">Cerrar Sesión</asp:HyperLink>
        <strong>
        <asp:Button ID="btnBuscar" runat="server" CssClass="style119" Height="33px" 
            Text="Buscar" Width="193px" onclick="btnBuscar_Click1" />
        <asp:Button ID="btnNuevo" runat="server" CssClass="style120" Height="33px" 
            onclick="btnNuevo_Click" Text="Nuevo" Width="193px" />
        </strong>
    </div>
</asp:Content>




