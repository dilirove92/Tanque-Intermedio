<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FormReportes.aspx.cs" Inherits="ProyectoTanqueIntermedioEpam.CapaPresentacion.FormReportes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title></title>
    <style type="text/css">
        #form1
        {
            height: 1025px;
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
            top: 74px;
            left: 582px;
            width: 235px;
            color: #CC3300;
        }
        .style7
        {
            background-image: url('ima/pantalla.jpg');
            text-align: right;
            height: 1003px;
            width: 1010px;
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
            height: 677px;
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
            background-image: url('ima/celeste.jpg');
        }
        .nuevoEstilo36
        {
            position: absolute;
            z-index: auto;
        }
        .nuevoEstilo37
        {
            background-image: url('ima/celeste.jpg');
        }
        .nuevoEstilo38
        {
            background-image: url('ima/celeste.jpg');
            position: absolute;
            z-index: auto;
            border: medium outset #C0C0C0;
        }
        .style33
        {
            background-image: url('ima/celeste.jpg');
            position: absolute;
            z-index: auto;
            border: medium outset #C0C0C0;
            left: 199px;
            top: 276px;
            font-family: "Times New Roman", Times, serif;
            font-size: medium;
            font-weight: bold;
            color: #FFFFFF;
            width: 193px;
        }
        .nuevoEstilo39
        {
            position: absolute;
            z-index: auto;
            background-image: url('ima/celeste.jpg');
        }
        .nuevoEstilo40
        {
            background-image: url('ima/celeste.jpg');
            position: absolute;
            z-index: auto;
            border: medium outset #C0C0C0;
        }
        .nuevoEstilo41
        {
            background-image: url('ima/celeste.jpg');
            border: medium outset #C0C0C0;
            position: absolute;
            z-index: auto;
        }
        .style35
        {
            background-image: url('ima/celeste.jpg');
            border: medium outset #C0C0C0;
            position: absolute;
            z-index: auto;
            left: 199px;
            top: 340px;
            width: 194px;
            font-weight: bold;
            font-size: medium;
            font-family: "Times New Roman", Times, serif;
            color: #FFFFFF;
        }
        .nuevoEstilo42
        {
            background-image: url('ima/celeste.jpg');
            border: medium outset #C0C0C0;
            position: absolute;
            z-index: auto;
        }
        .nuevoEstilo43
        {
            background-image: url('ima/celeste.jpg');
            border: medium outset #C0C0C0;
            position: absolute;
            z-index: auto;
        }
        .nuevoEstilo44
        {
            position: absolute;
            z-index: auto;
        }
        .nuevoEstilo45
        {
            position: absolute;
            z-index: auto;
        }
        .nuevoEstilo46
        {
            position: absolute;
            z-index: auto;
        }
        .nuevoEstilo47
        {
            position: absolute;
            z-index: auto;
        }
        .nuevoEstilo48
        {
            position: absolute;
            z-index: auto;
        }
        .nuevoEstilo49
        {
            position: absolute;
            z-index: auto;
        }
        .nuevoEstilo50
        {
            position: absolute;
            z-index: auto;
        }
        .nuevoEstilo51
        {
            position: absolute;
            z-index: auto;
        }
        .nuevoEstilo52
        {
            position: absolute;
            z-index: auto;
        }
        .nuevoEstilo53
        {
            position: absolute;
            z-index: auto;
        }
        .nuevoEstilo54
        {
            z-index: auto;
            position: absolute;
        }
        .nuevoEstilo55
        {
            position: absolute;
            z-index: auto;
        }
        .nuevoEstilo56
        {
            position: absolute;
            z-index: auto;
        }
        .nuevoEstilo57
        {
            z-index: auto;
            position: absolute;
        }
        .nuevoEstilo58
        {
            position: absolute;
            z-index: auto;
        }
        .nuevoEstilo59
        {
            position: absolute;
            z-index: auto;
        }
        .nuevoEstilo60
        {
            position: absolute;
            z-index: auto;
        }
        .nuevoEstilo61
        {
            position: absolute;
            z-index: auto;
        }
        .nuevoEstilo62
        {
            position: absolute;
            z-index: auto;
        }
        .nuevoEstilo63
        {
            position: absolute;
            z-index: auto;
        }
        .nuevoEstilo64
        {
            position: absolute;
            z-index: auto;
        }
        .nuevoEstilo65
        {
            position: absolute;
            z-index: auto;
        }
        .nuevoEstilo66
        {
            position: absolute;
            z-index: auto;
        }
        .nuevoEstilo67
        {
            position: absolute;
            z-index: auto;
        }
        .nuevoEstilo68
        {
            position: absolute;
            z-index: auto;
        }
        .nuevoEstilo69
        {
            position: absolute;
            z-index: auto;
        }
        .nuevoEstilo70
        {
            position: absolute;
            z-index: auto;
        }
        .nuevoEstilo71
        {
            position: absolute;
            z-index: auto;
        }
        .nuevoEstilo72
        {
            position: absolute;
            z-index: auto;
        }
        .nuevoEstilo73
        {
            position: absolute;
            z-index: auto;
        }
        .nuevoEstilo74
        {
            position: absolute;
            z-index: auto;
        }
        .nuevoEstilo75
        {
            position: absolute;
            z-index: auto;
        }
        .nuevoEstilo76
        {
            position: absolute;
            z-index: auto;
        }
        .nuevoEstilo77
        {
            position: absolute;
            z-index: auto;
        }
        .nuevoEstilo78
        {
            position: absolute;
            z-index: auto;
        }
        .nuevoEstilo79
        {
            position: absolute;
            z-index: auto;
        }
        .nuevoEstilo80
        {
            position: absolute;
            z-index: auto;
        }
        .nuevoEstilo81
        {
            position: absolute;
            z-index: auto;
        }
        .nuevoEstilo82
        {
            position: absolute;
            z-index: auto;
        }
        .nuevoEstilo83
        {
            position: absolute;
            z-index: auto;
        }
        .nuevoEstilo84
        {
            position: absolute;
            z-index: auto;
        }
        .nuevoEstilo85
        {
            position: absolute;
            z-index: auto;
        }
        .nuevoEstilo86
        {
            position: absolute;
            z-index: auto;
        }
        .nuevoEstilo87
        {
            background-image: url('ima/celeste.jpg');
            border: medium outset #C0C0C0;
            position: absolute;
            z-index: auto;
        }
        .nuevoEstilo88
        {
            position: absolute;
            z-index: auto;
        }
        .nuevoEstilo89
        {
            position: absolute;
            z-index: auto;
        }
        .nuevoEstilo90
        {
            position: absolute;
            z-index: auto;
        }
        .nuevoEstilo91
        {
            position: absolute;
            z-index: auto;
        }
        .nuevoEstilo92
        {
            position: absolute;
            z-index: auto;
        }
        .nuevoEstilo93
        {
            position: absolute;
            z-index: auto;
        }
        .nuevoEstilo94
        {
            position: absolute;
            z-index: auto;
        }
        .nuevoEstilo95
        {
            position: absolute;
            z-index: auto;
        }
        .nuevoEstilo96
        {
            position: absolute;
            z-index: auto;
        }
        .nuevoEstilo97
        {
            position: absolute;
            z-index: auto;
        }
        .nuevoEstilo98
        {
            position: absolute;
            z-index: auto;
        }
        .style60
        {
            position: absolute;
            z-index: auto;
            left: 151px;
            top: 119px;
            font-family: Arial;
            font-size: small;
        }
        .style61
        {
            position: absolute;
            z-index: auto;
            left: 151px;
            top: 147px;
            font-family: Arial;
            font-size: small;
        }
        .nuevoEstilo99
        {
            position: absolute;
            z-index: auto;
        }
        .style62
        {
            position: absolute;
            z-index: auto;
            left: 206px;
            top: 118px;
            width: 145px;
            height: 16px;
            font-family: Arial;
            font-size: small;
        }
        .nuevoEstilo100
        {
            position: absolute;
            z-index: auto;
        }
        .style63
        {
            position: absolute;
            z-index: auto;
            left: 206px;
            top: 146px;
            font-family: Arial;
            font-size: small;
        }
        .nuevoEstilo101
        {
            position: absolute;
            z-index: auto;
        }
        .style64
        {
            position: absolute;
            z-index: auto;
            left: 362px;
            top: 118px;
            font-family: Arial;
            font-size: small;
        }
        .style65
        {
            position: absolute;
            z-index: auto;
            left: 403px;
            top: 146px;
            font-family: Arial;
            font-size: small;
        }
        .nuevoEstilo102
        {
            position: absolute;
            z-index: auto;
        }
        .style66
        {
            position: absolute;
            z-index: auto;
            left: 525px;
            top: 117px;
            font-family: Arial;
            font-size: small;
        }
        .nuevoEstilo103
        {
            position: absolute;
            z-index: auto;
        }
        .style67
        {
            position: absolute;
            z-index: auto;
            left: 525px;
            top: 144px;
            font-family: Arial;
            font-size: small;
        }
        .nuevoEstilo104
        {
            position: absolute;
            z-index: auto;
        }
        .style68
        {
            position: absolute;
            z-index: auto;
            left: 208px;
            top: 54px;
            width: 375px;
            height: 37px;
        }
        .nuevoEstilo105
        {
            position: absolute;
            z-index: auto;
        }
        .style69
        {
            position: absolute;
            z-index: auto;
            left: 19px;
            top: 9px;
        }
        .nuevoEstilo106
        {
            position: absolute;
            z-index: auto;
        }
        .nuevoEstilo107
        {
            position: absolute;
            z-index: auto;
            background-color: #FFFFFF;
            border: thin groove #000000;
            font-family: Arial;
            color: #000000;
            font-size: small;
        }
        .nuevoEstilo108
        {
            position: absolute;
            z-index: auto;
        }
        .style72
        {
            position: absolute;
            z-index: auto;
            left: 128px;
            top: 6px;
            width: 223px;
        }
        .nuevoEstilo109
        {
            position: absolute;
            z-index: auto;
            background-image: url('ima/celeste.jpg');
            border: medium outset #C0C0C0;
        }
        .style73
        {
            position: absolute;
            z-index: auto;
            background-image: url('ima/celeste.jpg');
            border: medium outset #C0C0C0;
            left: 199px;
            top: 243px;
            width: 193px;
            height: 33px;
            font-family: "Times New Roman", Times, serif;
            font-size: medium;
            font-weight: bold;
            color: #FFFFFF;
        }
        .nuevoEstilo110
        {
            background-image: url('ima/celeste.jpg');
            border: medium outset #C0C0C0;
            position: absolute;
            z-index: auto;
        }
        .style74
        {
            background-image: url('ima/celeste.jpg');
            border: medium outset #C0C0C0;
            position: absolute;
            z-index: auto;
            left: 199px;
            top: 308px;
            width: 193px;
            height: 33px;
            font-weight: bold;
            font-family: "Times New Roman", Times, serif;
            font-size: medium;
            color: #FFFFFF;
        }
        .style11
        {
            position: absolute;
            z-index: auto;
            left: 202px;
            top: 956px;
            color: #CC3300;
            font-family: "Times New Roman", Times, serif;
            font-size: small;
            width: 139px;
            right: 646px;
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
        }
        .nuevoEstilo111
        {
            position: absolute;
            z-index: auto;
        }
        .style71
        {
            position: absolute;
            z-index: auto;
            left: 4px;
            top: 4px;
            height: 435px;
            width: 720px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="style7" 
        
        
        
        
        style="margin-left: 171px; margin-right: 0px; margin-top: 10px; background-image: url('ima/fondopantalla1.jpg');">
        <asp:Label ID="Label1" runat="server" CssClass="style6" 
            style="font-family: 'Times New Roman', Times, serif; font-weight: 700; font-size: larger; text-align: center" 
            Text="Reportes"></asp:Label>
        <hr class="style5" />
        <div class="style13" style="border: thin groove #C0C0C0">
            <hr class="style15" />
            <strong>
            <asp:Label ID="Label8" runat="server" CssClass="style16" 
                Text="Reportes"></asp:Label>
            </strong>
            <asp:Label ID="Label18" runat="server" CssClass="style61" Text="Fecha 2"></asp:Label>
            <strong>
            <asp:TextBox ID="txtFecha1" runat="server" CssClass="style62"></asp:TextBox>
            <asp:TextBox ID="txtFecha2" runat="server" CssClass="style63" height="16px" 
                width="145px"></asp:TextBox>
            </strong>
            <asp:Label ID="Label19" runat="server" CssClass="style64" 
                Text="Número de Guía Remisión"></asp:Label>
            <asp:Label ID="Label20" runat="server" CssClass="style65" 
                Text="Número de Factura"></asp:Label>
            <strong>
            <asp:TextBox ID="txtNumGuia" runat="server" CssClass="style66" height="16px" 
                width="145px"></asp:TextBox>
            <asp:TextBox ID="txtNumeroFactura" runat="server" CssClass="style67" height="16px" 
                width="145px"></asp:TextBox>
            </strong>
            <asp:Label ID="Label17" runat="server" CssClass="style60" Text="Fecha 1"></asp:Label>
            <div class="style68" style="border: thin groove #333333">
                <asp:Label ID="Label21" runat="server" CssClass="style69" 
                    Text="Tipo de Reporte"></asp:Label>
                <asp:DropDownList ID="cbxTipoReporte" runat="server" CssClass="style72">
                    <asp:ListItem>Entre fechas</asp:ListItem>
                    <asp:ListItem>Diario</asp:ListItem>
                    <asp:ListItem>Por número de Factura</asp:ListItem>
                    <asp:ListItem>Por número de Guía Remisión</asp:ListItem>
                </asp:DropDownList>
            </div>
            <div style="overflow: auto; width: 736px; Height: 452px; top: 186px; left: 11px;" 
                class="nuevoEstilo111">
                <asp:GridView ID="GridView1" runat="server" CssClass="style71" 
                BorderStyle="Double">
                    <AlternatingRowStyle Wrap="False" Height="20px" />
                    <EditRowStyle Wrap="True" />
                    <EmptyDataRowStyle Height="20px" Wrap="False" />
                    <HeaderStyle Height="30px" Wrap="False" />
                    <PagerStyle Height="20px" Wrap="False" />
                    <RowStyle Height="20px" Wrap="False" />
                </asp:GridView>
            </div>
        </div>
            <strong>
        <asp:Button ID="btnBuscar" runat="server" CssClass="style73" 
            onclick="btnBuscar_Click" width="193px" Text="Buscar" />
        <asp:Button ID="btnImprimir" runat="server" CssClass="style74" 
            onclick="btnImprimir_Click1" Text="Imprimir" />
        <asp:Button ID="btnNuevo" runat="server" CssClass="style33" height="33px" 
            Text="Nuevo" width="193px" onclick="btnNuevo_Click" />
        <asp:Button ID="btnSalir" runat="server" CssClass="style35" height="33px" 
            Text="Salir" width="193px" onclick="btnSalir_Click" />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        </strong>
        <asp:Label ID="Label5" runat="server" CssClass="style11" 
            Text="Tanque Intermedio "></asp:Label>
        <asp:Label ID="lblTipoUser" runat="server" CssClass="style12" 
            Text="|  Administrador o Usuario"></asp:Label>
        <asp:Label ID="lblFecha" runat="server" CssClass="style14" 
            Text="Domingo, 3 de Febrero del 2013"></asp:Label>
        <asp:Label ID="lblUser" runat="server" CssClass="style29" 
            Text="Bienvenid@:  NombreUser  |  "></asp:Label>
        <asp:HyperLink ID="HyperLink1" runat="server" CssClass="style30" 
            NavigateUrl="~/FormMedidorIS.aspx">Cerrar Sesión</asp:HyperLink>
        <strong>
        <br />        
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
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
         
    </script>

</asp:Content>

