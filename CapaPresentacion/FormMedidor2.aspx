<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FormMedidor2.aspx.cs" Inherits="ProyectoTanqueIntermedioEpam.CapaPresentacion.FormMedidor2" %>
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
            top: 72px;
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
        .nuevoEstilo21
        {
            position: absolute;
            z-index: auto;
        }
        .style19
        {
            position: absolute;
            z-index: auto;
            left: 81px;
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
            left: 86px;
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
            left: 125px;
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
            left: 90px;
            top: 117px;
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
            left: 50px;
            top: 142px;
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
        .style28
        {
            position: absolute;
            z-index: auto;
            left: 180px;
            top: 117px;
            font-family: Arial;
            font-size: small;
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
            left: 180px;
            top: 142px;
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
        .style34
        {
            position: absolute;
            z-index: auto;
            background-image: url('ima/celeste.jpg');
            border: medium outset #C0C0C0;
            left: 199px;
            top: 241px;
            font-size: medium;
            font-family: "Times New Roman", Times, serif;
            color: #FFFFFF;
            font-weight: bold;
        }
        .style35
        {
            background-image: url('ima/celeste.jpg');
            border: medium outset #C0C0C0;
            position: absolute;
            z-index: auto;
            left: 199px;
            top: 273px;
            font-size: medium;
            font-family: "Times New Roman", Times, serif;
            color: #FFFFFF;
            font-weight: bold;
        }
        .style36
        {
            background-image: url('ima/celeste.jpg');
            border: medium outset #C0C0C0;
            position: absolute;
            z-index: auto;
            left: 199px;
            top: 306px;
            font-size: medium;
            font-family: "Times New Roman", Times, serif;
            color: #FFFFFF;
            font-weight: bold;
        }
        .style37
        {
            background-image: url('ima/celeste.jpg');
            border: medium outset #C0C0C0;
            position: absolute;
            z-index: auto;
            left: 199px;
            top: 372px;
            font-size: medium;
            font-family: "Times New Roman", Times, serif;
            color: #FFFFFF;
            font-weight: bold;
        }
        .nuevoEstilo34
        {
            position: absolute;
            z-index: auto;
        }
        .style38
        {
            position: absolute;
            z-index: auto;
            font-family: Arial;
            font-size: small;
            left: 100px;
            top: 14px;
        }
        .nuevoEstilo35
        {
            position: absolute;
            z-index: auto;
        }
        .style39
        {
            position: absolute;
            z-index: auto;
            left: 179px;
            top: 12px;
            width: 145px;
            height: 16px;
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
        .nuevoEstilo36
        {
            position: absolute;
            z-index: auto;
        }
        .style40
        {
            position: absolute;
            z-index: auto;
            left: 902px;
            top: 32px;
            width: 165px;
            font-family: "Times New Roman", Times, serif;
            font-size: small;
            color: #FFFFFF;
        }
        .nuevoEstilo37
        {
            border: medium outset #C0C0C0;
            background-image: url('ima/celeste.jpg');
            position: absolute;
            z-index: auto;
        }
        .style41
        {
            background-image: url('ima/celeste.jpg');
            border: medium outset #C0C0C0;
            position: absolute;
            z-index: auto;
            left: 199px;
            top: 339px;
            font-size: medium;
            font-family: "Times New Roman", Times, serif;
            color: #FFFFFF;
            font-weight: bold;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="style7" 
        
        
        
        style="height: 629px; width: 1010px; margin-left: 171px; margin-right: 0px; margin-top: 10px; background-image: url('ima/fondopantalla.jpg');">
        <asp:Label ID="Label1" runat="server" CssClass="style6" 
            style="font-family: 'Times New Roman', Times, serif; font-weight: 700; font-size: larger; text-align: center" 
            Text="Datos del Medidor"></asp:Label>
        <hr class="style5" />
        <asp:Label ID="Label5" runat="server" CssClass="style11" 
            Text="Tanque Intermedio "></asp:Label>
        <asp:Label ID="lblTipoUser" runat="server" CssClass="style12" 
            Text="|  Administrador o Usuario"></asp:Label>
        <asp:Label ID="lblFecha" runat="server" CssClass="style14" 
            Text="Domingo, 3 de Febrero del 2013"></asp:Label>
        <asp:HyperLink ID="HyperLink1" runat="server" CssClass="style30" 
            NavigateUrl="~/FormMedidorIS.aspx">Cerrar Sesión</asp:HyperLink>
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
                <asp:Label ID="Label13" runat="server" CssClass="style22" Text="Observación"></asp:Label>
                <asp:TextBox ID="txtLecturaIni" runat="server" CssClass="style25" height="16px" 
                    width="145px"></asp:TextBox>
                <asp:TextBox ID="txtID" runat="server" CssClass="style39"></asp:TextBox>
                <asp:TextBox ID="txtLecturaFin" runat="server" CssClass="style26" height="16px" 
                    width="145px"></asp:TextBox>
                <asp:TextBox ID="txtFecha" runat="server" CssClass="style27" height="16px" 
                    width="145px"></asp:TextBox>
                <asp:TextBox ID="txtUsuario" runat="server" CssClass="style29" height="16px" 
                    width="145px"></asp:TextBox>
                <asp:TextBox ID="txtObservacion" runat="server" CssClass="style28" height="16px" 
                    width="145px"></asp:TextBox>
                <asp:Label ID="Label15" runat="server" CssClass="style38" Text="Id Medidor"></asp:Label>
            </div>
        </div>
        <strong>
        <asp:Button ID="btnBuscar" runat="server" CssClass="style34" height="33px" 
            Text="Buscar" width="193px" onclick="btnBuscar_Click" />
        <asp:Button ID="btnModificar" runat="server" CssClass="style35" height="33px" 
            Text="Modificar" width="193px" onclick="btnModificar_Click" />
        <asp:Button ID="btnEliminar" runat="server" CssClass="style36" height="33px" 
            Text="Eliminar" width="193px" onclick="btnEliminar_Click" />
        <asp:Button ID="btnSalir" runat="server" CssClass="style37" height="33px" 
            Text="Salir" width="193px" onclick="btnSalir_Click" />
        </strong>
        <asp:Label ID="lblUser" runat="server" CssClass="style40" 
            Text="Bienvenid@:  NombreUser  |  "></asp:Label>
        <strong>
        <asp:Button ID="btnNuevo" runat="server" CssClass="style41" Height="33px" 
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

        function ValidText(e) {
            var tecla = document.all ? tecla = e.keyCode : tecla = e.which;
            return ((tecla > 64 && tecla < 91) || (tecla > 96 && tecla < 123) || (tecla > 159 || tecla < 164)
                    || tecla == 130 || tecla == 181 || tecla == 144 || tecla == 214 || tecla == 224 || tecla == 233
                    || tecla == 08 || tecla == 32);
        }   
            
    </script>

</asp:Content>

