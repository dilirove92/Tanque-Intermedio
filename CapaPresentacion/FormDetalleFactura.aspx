<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FormDetalleFactura.aspx.cs" Inherits="ProyectoTanqueIntermedioEpam.CapaPresentacion.FormDetalleFactura" %>
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
            width: 201px;
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
            text-align: center;
        }
        .nuevoEstilo20
        {
            position: absolute;
            z-index: auto;
        }
        .style18
        {
            position: absolute;
            z-index: auto;
            left: 58px;
            top: 14px;
            font-family: Arial;
            font-size: small;
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
            left: 61px;
            top: 39px;
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
            left: 64px;
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
            left: 67px;
            top: 91px;
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
            left: 67px;
            top: 122px;
            font-family: Arial;
            font-size: small;
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
        .style24
        {
            position: absolute;
            z-index: auto;
            left: 180px;
            top: 13px;
            height: 16px;
            width: 145px;
            font-family: Arial;
            font-size: small;
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
            left: 180px;
            top: 39px;
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
            left: 180px;
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
            left: 180px;
            top: 91px;
            font-family: Arial;
            font-size: small;
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
            top: 243px;
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
        .style34
        {
            background-image: url('ima/celeste.jpg');
            position: absolute;
            z-index: auto;
            border: medium outset #C0C0C0;
            left: 199px;
            top: 270px;
            width: 193px;
            color: #FFFFFF;
            font-weight: bold;
            font-size: medium;
            font-family: "Times New Roman", Times, serif;
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
            top: 302px;
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
        .style36
        {
            background-image: url('ima/celeste.jpg');
            border: medium outset #C0C0C0;
            position: absolute;
            z-index: auto;
            font-weight: bold;
            font-size: medium;
            font-family: "Times New Roman", Times, serif;
            color: #FFFFFF;
            left: 199px;
            top: 334px;
            width: 193px;
        }
        .nuevoEstilo43
        {
            background-image: url('ima/celeste.jpg');
            border: medium outset #C0C0C0;
            position: absolute;
            z-index: auto;
        }
        .style37
        {
            background-image: url('ima/celeste.jpg');
            border: medium outset #C0C0C0;
            position: absolute;
            z-index: auto;
            font-weight: bold;
            font-size: medium;
            font-family: "Times New Roman", Times, serif;
            color: #FFFFFF;
            left: 199px;
            top: 400px;
            width: 193px;
        }
        .nuevoEstilo44
        {
            position: absolute;
            z-index: auto;
        }
        .style38
        {
            position: absolute;
            z-index: auto;
            left: 61px;
            top: 150px;
            font-family: Arial;
            font-size: small;
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
        .style41
        {
            position: absolute;
            z-index: auto;
            left: 8px;
            top: 175px;
            font-family: Arial;
            font-size: small;
        }
        .style42
        {
            position: absolute;
            z-index: auto;
            left: 70px;
            top: 202px;
            font-family: Arial;
            font-size: small;
        }
        .nuevoEstilo48
        {
            position: absolute;
            z-index: auto;
        }
        .style43
        {
            position: absolute;
            z-index: auto;
            left: 180px;
            top: 175px;
            font-family: Arial;
        }
        .nuevoEstilo49
        {
            position: absolute;
            z-index: auto;
        }
        .style44
        {
            position: absolute;
            z-index: auto;
            left: 180px;
            top: 200px;
            font-family: Arial;
        }
        .nuevoEstilo50
        {
            position: absolute;
            z-index: auto;
        }
        .style45
        {
            position: absolute;
            z-index: auto;
            left: 181px;
            top: 147px;
            width: 150px;
            height: 22px;
            font-family: Arial;
            font-size: small;
        }
        .nuevoEstilo51
        {
            position: absolute;
            z-index: auto;
        }
        .style46
        {
            position: absolute;
            z-index: auto;
            left: 182px;
            top: 119px;
            width: 152px;
            height: 22px;
            font-family: Arial;
            font-size: small;
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
        .style14
        {
            position: absolute;
            z-index: auto;
            font-family: "Times New Roman", Times, serif;
            font-size: small;
            left: 991px;
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
        .nuevoEstilo52
        {
            background-image: url('ima/celeste.jpg');
            border: medium outset #C0C0C0;
            position: absolute;
            z-index: auto;
        }
        .style47
        {
            background-image: url('ima/celeste.jpg');
            border: medium outset #C0C0C0;
            position: absolute;
            z-index: auto;
            left: 199px;
            top: 367px;
            font-family: "Times New Roman", Times, serif;
            font-size: medium;
            font-weight: bold;
            color: #FFFFFF;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="style7" 
        
        
        
        style="height: 629px; width: 1010px; margin-left: 171px; margin-right: 0px; margin-top: 10px; background-image: url('ima/fondopantalla.jpg');">
        <asp:Label ID="Label1" runat="server" CssClass="style6" 
            style="font-family: 'Times New Roman', Times, serif; font-weight: 700; font-size: larger; text-align: center" 
            Text="Detalle de Factura"></asp:Label>
        <hr class="style5" />
        <asp:Label ID="Label5" runat="server" CssClass="style11" 
            Text="Tanque Intermedio "></asp:Label>
        <asp:Label ID="lblFecha" runat="server" CssClass="style14" 
            Text="Domingo, 3 de Febrero del 2013"></asp:Label>
        <asp:Label ID="lblUser" runat="server" CssClass="style29" 
            Text="Bienvenid@:  NombreUser  |  "></asp:Label>
        <asp:HyperLink ID="HyperLink1" runat="server" CssClass="style30" 
            NavigateUrl="~/FormMedidorIS.aspx">Cerrar Sesión</asp:HyperLink>
        <asp:Label ID="lblTipoUser" runat="server" CssClass="style12" 
            Text="|  Administrador o Usuario"></asp:Label>
        <div class="style13" style="border: thin groove #C0C0C0">
            <hr class="style15" />
            <strong>
            <asp:Label ID="Label8" runat="server" CssClass="style16" 
                Text="Factura"></asp:Label>
            </strong>
            <div class="style17" style="border: thin groove #CC3300">
                <asp:Label ID="Label9" runat="server" CssClass="style18" 
                    Text="Número de Factura"></asp:Label>
                <asp:Label ID="Label11" runat="server" CssClass="style20" 
                    Text="Fecha de Emisión"></asp:Label>
                <asp:Label ID="Label10" runat="server" CssClass="style19" 
                    Text="Número de Control"></asp:Label>
                <asp:Label ID="Label12" runat="server" CssClass="style21" 
                    Text="Fecha de Factura"></asp:Label>
                <asp:Label ID="Label13" runat="server" CssClass="style22" 
                    Text="Cédula de Cliente"></asp:Label>
                <asp:DropDownList ID="cbxPlacaTanq" runat="server" CssClass="style45" 
                    onprerender="cbxPlacaTanq_PreRender">
                </asp:DropDownList>
                <asp:TextBox ID="txtNumFactura" runat="server" CssClass="style24"></asp:TextBox>
                <asp:TextBox ID="txtNumControl" runat="server" CssClass="style25" height="16px" 
                    width="145px"></asp:TextBox>
                <asp:TextBox ID="txtFechaEmision" runat="server" CssClass="style26" height="16px" 
                    width="145px"></asp:TextBox>
                <asp:TextBox ID="txtValorCancelado" runat="server" CssClass="style44" 
                    Height="16px" Width="145px"></asp:TextBox>
                <asp:TextBox ID="txtFechaFactura" runat="server" CssClass="style27" height="16px" 
                    width="145px"></asp:TextBox>
                <asp:Label ID="Label16" runat="server" CssClass="style38" 
                    Text="Placa de Tanquero"></asp:Label>
                <asp:TextBox ID="txtMCFacturados" runat="server" CssClass="style43" 
                    Height="16px" Width="145px"></asp:TextBox>
                <asp:Label ID="Label17" runat="server" CssClass="style42" 
                    Text="Valor Cancelado"></asp:Label>
                <asp:Label ID="Label18" runat="server" CssClass="style41" 
                    Text="Metros Cubicos Facturados"></asp:Label>
                <asp:DropDownList ID="cbxCedulaCli" runat="server" CssClass="style46" 
                    onprerender="cbxCedulaCli_PreRender">
                </asp:DropDownList>
            </div>
        </div>
        <strong>
        <asp:Button ID="btnGuardar" runat="server" CssClass="style33" height="33px"
            Text="Guardar" width="193px" onclick="btnGuardar_Click" />
        <asp:Button ID="btnBuscar" runat="server" CssClass="style34" height="33px" 
            Text="Buscar" width="193px" onclick="btnBuscar_Click" />
        <asp:Button ID="btnModificar" runat="server" CssClass="style35" height="33px" 
            Text="Modificar" width="193px" onclick="btnModificar_Click" />
        <asp:Button ID="btnEliminar" runat="server" CssClass="style36" height="33px" 
            Text="Eliminar" width="193px" onclick="btnEliminar_Click" />
        <asp:Button ID="btnSalir" runat="server" CssClass="style37" height="33px" 
            Text="Salir" width="193px" onclick="btnSalir_Click" />
        <asp:Button ID="btnNuevo" runat="server" CssClass="style47" Height="33px" 
            onclick="btnNuevo_Click" Text="Nuevo" Width="193px" />
        </strong>
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

        function ValidCed(e) {
            var tecla = document.all ? tecla = e.keyCode : tecla = e.which;
            return ((tecla > 47 && tecla < 58) || tecla == 45 || tecla == 08);
        }

        function ValidPlaca(e) {
            var tecla = document.all ? tecla = e.keyCode : tecla = e.which;
            return ((tecla > 47 && tecla < 58) || (tecla > 64 && tecla < 91) || tecla == 45 || tecla == 08);
        }

        function ValidDecimal(e) {
            var tecla = document.all ? tecla = e.keyCode : tecla = e.which;
            return ((tecla > 47 && tecla < 58) || tecla == 08 || tecla == 44 || tecla == 46);
        }
        

    </script>

</asp:Content>

