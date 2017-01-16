<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FormGuiaRemisionGeneral.aspx.cs" Inherits="ProyectoTanqueIntermedioEpam.CapaPresentacion.FormGuiaRemisionGeneral" %>
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
            left: 398px;
            top: 243px;
            width: 760px;
            height: 692px;
            text-align: justify;
            bottom: 80px;
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
            left: 5px;
            top: 48px;
            width: 748px;
            height: 635px;
            text-align: center;
            bottom: 21px;
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
            left: 73px;
            top: 58px;
            font-family: Arial;
            font-size: small;
            bottom: 564px;
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
            left: 57px;
            top: 85px;
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
            left: 57px;
            top: 30px;
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
            left: 24px;
            top: 142px;
            font-family: Arial;
            font-size: small;
            right: 580px;
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
            left: 431px;
            top: 56px;
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
        .nuevoEstilo27
        {
            position: absolute;
            z-index: auto;
        }
        .style25
        {
            position: absolute;
            z-index: auto;
            left: 178px;
            top: 85px;
            height: 16px;
            width: 180px;
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
            left: 178px;
            top: 30px;
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
            left: 177px;
            top: 141px;
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
            left: 528px;
            top: 56px;
            font-family: Arial;
            font-size: small;
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
            top: 242px;
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
            top: 273px;
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
            top: 304px;
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
            top: 335px;
            width: 193px;
            bottom: 296px;
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
            top: 366px;
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
            left: 441px;
            top: 79px;
            bottom: 596px;
            font-family: Arial;
            font-size: small;
            height: 17px;
        }
        .nuevoEstilo45
        {
            position: absolute;
            z-index: auto;
        }
        .style39
        {
            position: absolute;
            z-index: auto;
            left: 534px;
            top: 79px;
            font-family: Arial;
            font-size: small;
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
            left: 393px;
            top: 191px;
            font-family: Arial;
            font-size: small;
        }
        .nuevoEstilo48
        {
            position: absolute;
            z-index: auto;
        }
        .style42
        {
            position: absolute;
            z-index: auto;
            left: 0px;
            top: 0px;
            width: 748px;
            background-color: #CCCCCC;
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
        .style44
        {
            position: absolute;
            z-index: auto;
            left: 176px;
            top: 169px;
            width: 173px;
            font-family: Arial;
            font-size: small;
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
        .style46
        {
            position: absolute;
            z-index: auto;
            left: 72px;
            top: 170px;
            font-family: Arial;
            font-size: small;
        }
        .nuevoEstilo53
        {
            position: absolute;
            z-index: auto;
        }
        .style47
        {
            position: absolute;
            z-index: auto;
            left: 411px;
            top: 169px;
            font-family: Arial;
            font-size: small;
        }
        .nuevoEstilo54
        {
            z-index: auto;
            position: absolute;
        }
        .style48
        {
            z-index: auto;
            position: absolute;
            left: 1px;
            top: 204px;
            width: 746px;
            font-size: medium;
            background-color: #CCCCCC;
        }
        .nuevoEstilo55
        {
            position: absolute;
            z-index: auto;
        }
        .style49
        {
            position: absolute;
            z-index: auto;
            left: 116px;
            top: 264px;
            font-family: Arial;
            font-size: small;
        }
        .nuevoEstilo56
        {
            position: absolute;
            z-index: auto;
        }
        .style50
        {
            position: absolute;
            z-index: auto;
            left: 466px;
            top: 237px;
            font-family: Arial;
            font-size: small;
        }
        .nuevoEstilo57
        {
            z-index: auto;
            position: absolute;
        }
        .style51
        {
            z-index: auto;
            position: absolute;
            left: 180px;
            top: 264px;
            font-family: Arial;
            font-size: small;
        }
        .nuevoEstilo58
        {
            position: absolute;
            z-index: auto;
        }
        .style52
        {
            position: absolute;
            z-index: auto;
            left: 527px;
            top: 237px;
            font-family: Arial;
            font-size: small;
        }
        .nuevoEstilo59
        {
            position: absolute;
            z-index: auto;
        }
        .style53
        {
            position: absolute;
            z-index: auto;
            left: 104px;
            top: 287px;
            font-family: Arial;
            font-size: small;
        }
        .nuevoEstilo60
        {
            position: absolute;
            z-index: auto;
        }
        .style54
        {
            position: absolute;
            z-index: auto;
            left: 470px;
            top: 264px;
            font-family: Arial;
            font-size: small;
        }
        .nuevoEstilo61
        {
            position: absolute;
            z-index: auto;
        }
        .style55
        {
            position: absolute;
            z-index: auto;
            left: 179px;
            top: 237px;
            height: 13px;
            font-family: Arial;
            font-size: small;
        }
        .nuevoEstilo62
        {
            position: absolute;
            z-index: auto;
        }
        .style56
        {
            position: absolute;
            z-index: auto;
            left: 533px;
            top: 314px;
            font-family: Arial;
            font-size: small;
        }
        .nuevoEstilo63
        {
            position: absolute;
            z-index: auto;
        }
        .style58
        {
            position: absolute;
            z-index: auto;
            left: 527px;
            top: 293px;
            width: 175px;
            font-family: Arial;
            font-size: small;
        }
        .nuevoEstilo64
        {
            position: absolute;
            z-index: auto;
        }
        .style59
        {
            position: absolute;
            z-index: auto;
            left: 425px;
            top: 342px;
            height: 19px;
            font-family: Arial;
            font-size: small;
            right: 235px;
        }
        .nuevoEstilo65
        {
            position: absolute;
            z-index: auto;
        }
        .style60
        {
            position: absolute;
            z-index: auto;
            left: 1px;
            top: 330px;
            width: 747px;
            font-size: medium;
            background-color: #CCCCCC;
        }
        .nuevoEstilo66
        {
            position: absolute;
            z-index: auto;
        }
        .style61
        {
            position: absolute;
            z-index: auto;
            left: 96px;
            top: 361px;
            font-family: Arial;
            font-size: small;
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
        .style63
        {
            position: absolute;
            z-index: auto;
            left: 460px;
            top: 388px;
            right: 231px;
            font-family: Arial;
            font-size: small;
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
        .style65
        {
            position: absolute;
            z-index: auto;
            left: 2px;
            top: 426px;
            width: 744px;
            font-size: medium;
            background-color: #CCCCCC;
        }
        .nuevoEstilo71
        {
            position: absolute;
            z-index: auto;
        }
        .style66
        {
            position: absolute;
            z-index: auto;
            left: 398px;
            top: 458px;
            font-family: Arial;
            font-size: small;
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
        .style68
        {
            position: absolute;
            z-index: auto;
            left: 457px;
            top: 487px;
            font-family: Arial;
            font-size: small;
        }
        .nuevoEstilo74
        {
            position: absolute;
            z-index: auto;
        }
        .style69
        {
            position: absolute;
            z-index: auto;
            left: 133px;
            top: 488px;
            font-family: Arial;
            font-size: small;
        }
        .nuevoEstilo75
        {
            position: absolute;
            z-index: auto;
        }
        .style70
        {
            position: absolute;
            z-index: auto;
            left: 135px;
            top: 460px;
            font-family: Arial;
            font-size: small;
        }
        .nuevoEstilo76
        {
            position: absolute;
            z-index: auto;
        }
        .style71
        {
            position: absolute;
            z-index: auto;
            left: 178px;
            top: 488px;
            width: 171px;
            font-family: Arial;
            font-size: small;
        }
        .nuevoEstilo77
        {
            position: absolute;
            z-index: auto;
        }
        .style72
        {
            position: absolute;
            z-index: auto;
            left: 528px;
            top: 487px;
            font-family: Arial;
            font-size: small;
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
        .style74
        {
            position: absolute;
            z-index: auto;
            left: 0px;
            top: 526px;
            width: 747px;
            font-size: medium;
            background-color: #CCCCCC;
        }
        .nuevoEstilo80
        {
            position: absolute;
            z-index: auto;
        }
        .style75
        {
            position: absolute;
            z-index: auto;
            left: 109px;
            top: 556px;
            width: 548px;
            height: 56px;
        }
        .nuevoEstilo81
        {
            position: absolute;
            z-index: auto;
        }
        .style76
        {
            position: absolute;
            z-index: auto;
            left: 49px;
            top: 4px;
            font-family: Arial;
            font-size: small;
        }
        .nuevoEstilo82
        {
            position: absolute;
            z-index: auto;
        }
        .style77
        {
            position: absolute;
            z-index: auto;
            left: 192px;
            top: 4px;
            font-family: Arial;
            font-size: small;
        }
        .nuevoEstilo83
        {
            position: absolute;
            z-index: auto;
        }
        .style78
        {
            position: absolute;
            z-index: auto;
            left: 384px;
            top: 4px;
            font-family: Arial;
            font-size: small;
        }
        .nuevoEstilo84
        {
            position: absolute;
            z-index: auto;
        }
        .style79
        {
            position: absolute;
            z-index: auto;
            left: 22px;
            top: 23px;
            right: 412px;
            width: 114px;
            font-family: Arial;
            font-size: small;
        }
        .nuevoEstilo85
        {
            position: absolute;
            z-index: auto;
        }
        .style80
        {
            position: absolute;
            z-index: auto;
            left: 154px;
            top: 22px;
            height: 22px;
            right: 280px;
            font-family: Arial;
            font-size: small;
        }
        .nuevoEstilo86
        {
            position: absolute;
            z-index: auto;
        }
        .style81
        {
            position: absolute;
            z-index: auto;
            left: 289px;
            top: 23px;
            width: 247px;
            font-family: Arial;
            font-size: small;
        }
        .nuevoEstilo87
        {
            background-image: url('ima/celeste.jpg');
            border: medium outset #C0C0C0;
            position: absolute;
            z-index: auto;
        }
        .style82
        {
            background-image: url('ima/celeste.jpg');
            border: medium outset #C0C0C0;
            position: absolute;
            z-index: auto;
            left: 199px;
            top: 432px;
            width: 176px;
            height: 42px;
            font-family: "Times New Roman", Times, serif;
            font-size: medium;
            font-weight: bold;
            color: #FFFFFF;
        }
        .style84
        {
            position: absolute;
            z-index: auto;
            left: 528px;
            top: 458px;
            font-family: Arial;
            font-size: small;
        }
        .style85
        {
            position: absolute;
            z-index: auto;
            left: 107px;
            top: 292px;
            font-family: Arial;
            font-size: small;
            width: 64px;
            height: 20px;
        }
        .nuevoEstilo88
        {
            position: absolute;
            z-index: auto;
        }
        .style86
        {
            position: absolute;
            z-index: auto;
            left: 180px;
            top: 293px;
            width: 176px;
        }
        .style87
        {
            position: absolute;
            z-index: auto;
            left: 114px;
            top: 389px;
            font-family: Arial;
            font-size: small;
        }
        .nuevoEstilo89
        {
            position: absolute;
            z-index: auto;
        }
        .style88
        {
            position: absolute;
            z-index: auto;
            left: 177px;
            top: 390px;
            height: 17px;
            width: 173px;
        }
        .nuevoEstilo90
        {
            position: absolute;
            z-index: auto;
        }
        .style89
        {
            position: absolute;
            z-index: auto;
            left: 177px;
            top: 113px;
            width: 180px;
            height: 16px;
        }
        .nuevoEstilo91
        {
            position: absolute;
            z-index: auto;
        }
        .style90
        {
            position: absolute;
            z-index: auto;
            left: 527px;
            top: 113px;
            width: 180px;
            height: 16px;
        }
        .style91
        {
            position: absolute;
            z-index: auto;
            left: 7px;
            top: 114px;
            font-family: Arial;
            font-size: small;
            right: 578px;
        }
        .style92
        {
            position: absolute;
            z-index: auto;
            left: 419px;
            top: 114px;
            font-family: Arial;
            font-size: small;
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
            right: 601px;
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
        .nuevoEstilo92
        {
            position: absolute;
            z-index: auto;
        }
        .style93
        {
            position: absolute;
            z-index: auto;
            left: 207px;
            top: 498px;
            width: 178px;
            color: #000066;
        }
        .nuevoEstilo93
        {
            position: absolute;
            z-index: auto;
        }
        .style94
        {
            position: absolute;
            z-index: auto;
            left: 178px;
            top: 55px;
            width: 180px;
            height: 25px;
            font-family: Arial;
            font-size: small;
        }
        .nuevoEstilo94
        {
            position: absolute;
            z-index: auto;
        }
        .style95
        {
            position: absolute;
            z-index: auto;
            left: 527px;
            top: 140px;
        }
        .nuevoEstilo95
        {
            position: absolute;
            z-index: auto;
        }
        .style96
        {
            position: absolute;
            z-index: auto;
            left: 527px;
            top: 166px;
        }
        .nuevoEstilo96
        {
            position: absolute;
            z-index: auto;
        }
        .style97
        {
            position: absolute;
            z-index: auto;
            left: 524px;
            top: 389px;
        }
        .nuevoEstilo97
        {
            position: absolute;
            z-index: auto;
        }
        .style98
        {
            position: absolute;
            z-index: auto;
            left: 178px;
            top: 357px;
            width: 183px;
            height: 16px;
        }
        .nuevoEstilo98
        {
            position: absolute;
            z-index: auto;
        }
        .style99
        {
            position: absolute;
            z-index: auto;
            left: 179px;
            top: 456px;
            width: 179px;
            height: 19px;
        }
        .nuevoEstilo99
        {
            background-image: url('ima/gris1.jpg');
            border: thin groove #C0C0C0;
            position: absolute;
            z-index: auto;
        }
        .nuevoEstilo100
        {
            background-image: url('ima/celeste.jpg');
            border: medium outset #C0C0C0;
            position: absolute;
            z-index: auto;
        }
        .style101
        {
            background-image: url('ima/celeste.jpg');
            border: medium outset #C0C0C0;
            position: absolute;
            z-index: auto;
            left: 199px;
            top: 399px;
            font-family: "Times New Roman", Times, serif;
            font-size: medium;
            font-weight: bold;
            color: #FFFFFF;
        }
        .nuevoEstilo101
        {
            position: absolute;
            z-index: auto;
        }
        .nuevoEstilo102
        {
            position: absolute;
            z-index: auto;
        }
        .nuevoEstilo103
        {
            position: Absolute;
            z-index: Auto;
        }
        .style102
        {
            position: Absolute;
            z-index: Auto;
            left: 368px;
            top: 237px;
            width: 16px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="style7" 
        
        
        
        
        style="margin-left: 171px; margin-right: 0px; margin-top: 10px; background-image: url('ima/fondopantalla1.jpg');">
        <asp:Label ID="Label1" runat="server" CssClass="style6" 
            style="font-family: 'Times New Roman', Times, serif; font-weight: 700; font-size: larger; text-align: center" 
            Text="Guía Remisión"></asp:Label>
        <hr class="style5" />
        <div class="style13" style="border: thin groove #C0C0C0">
            <hr class="style15" />
            <asp:Label ID="Label17" runat="server" CssClass="style41" 
                Text="Fecha Fin de Traslado"></asp:Label>
            <asp:Label ID="Label27" runat="server" CssClass="style59" 
                Text="Punto de Destino"></asp:Label>
            <strong>
            <asp:Label ID="Label8" runat="server" CssClass="style16" 
                Text="Guía Remisión  |  R.U.C. 1360064440001"></asp:Label>
            </strong>
            <div class="style17" style="border: thin groove #CC3300">
                <asp:Label ID="Label11" runat="server" CssClass="style20" 
                    Text="Número de Factura"></asp:Label>
                <strong>
                <asp:Label ID="Label22" runat="server" CssClass="style48" 
                    Text="Datos del Cliente"></asp:Label>
                </strong>
                <asp:Label ID="Label10" runat="server" CssClass="style19" 
                    Text="Número de Control"></asp:Label>
                <asp:Label ID="Label12" runat="server" CssClass="style21" 
                    Text="Fecha Inicio del Traslado"></asp:Label>
                <asp:Label ID="Label13" runat="server" CssClass="style22" Text="Fecha Emisión"></asp:Label>
                <asp:TextBox ID="txtNumControl" runat="server" CssClass="style25" height="16px" 
                    width="180px"></asp:TextBox>
                <asp:TextBox ID="txtNumFactura" runat="server" CssClass="style26" height="16px" 
                    width="180px"></asp:TextBox>
                <asp:TextBox ID="txtFechaInicioT" runat="server" CssClass="style27" height="16px" 
                    width="180px"></asp:TextBox>
                <asp:TextBox ID="txtFechaEmision" runat="server" CssClass="style28" height="16px" 
                    width="180px"></asp:TextBox>
                <asp:TextBox ID="txtMCFacturados" runat="server" CssClass="style89"></asp:TextBox>
                <asp:Label ID="Label9" runat="server" CssClass="style18" Text="Número de Guía"></asp:Label>
                <strong>
                <asp:Label ID="Label31" runat="server" CssClass="style65" 
                    Text="Datos del Tanquero"></asp:Label>
                <asp:TextBox ID="txtNTanquero" runat="server" CssClass="style84" height="16px" 
                    width="180px"></asp:TextBox>
                <asp:Label ID="Label36" runat="server" CssClass="style74" 
                    Text="Bienes Transportados"></asp:Label>
                <asp:Label ID="Label18" runat="server" CssClass="style42" 
                    Text="Datos de Guía Remisión"></asp:Label>
                <asp:TextBox ID="txtPuntoPartida" runat="server" CssClass="style44" Height="16px" 
                    Width="180px"></asp:TextBox>
                </strong>
                <asp:Label ID="Label20" runat="server" CssClass="style46" 
                    Text="Punto de Partida"></asp:Label>
                <asp:Label ID="Label21" runat="server" CssClass="style47" 
                    Text="Hora de Despacho"></asp:Label>
                <asp:Label ID="Label23" runat="server" CssClass="style49" Text="Nombres"></asp:Label>
                <asp:Label ID="Label24" runat="server" CssClass="style50" Text="Domicilo"></asp:Label>
                <asp:TextBox ID="txtNomCliente" runat="server" CssClass="style51" Height="16px" 
                    Width="180px"></asp:TextBox>
                <asp:TextBox ID="txtDireccionCli" runat="server" CssClass="style52" Height="16px" 
                    Width="180px"></asp:TextBox>
                <asp:Label ID="Label26" runat="server" CssClass="style54" Text="Teléfono"></asp:Label>
                <asp:TextBox ID="txtCedCliente" runat="server" CssClass="style55" Height="16px" 
                    Width="180px" AutoPostBack="True"></asp:TextBox>
                <asp:TextBox ID="txtPuntoDestino" runat="server" CssClass="style58" 
                    Height="16px" Width="180px"></asp:TextBox>
                <strong>
                <asp:Label ID="Label28" runat="server" CssClass="style60" 
                    Text="Identificación de persona encargada de Transporte"></asp:Label>
                </strong>
                <asp:Label ID="Label29" runat="server" CssClass="style61" Text="Cédula/RUC"></asp:Label>
                <asp:Label ID="Label30" runat="server" CssClass="style63" Text="Apellidos"></asp:Label>
                <asp:Label ID="Label32" runat="server" CssClass="style66" 
                    Text="Número de Tanquero"></asp:Label>
                <asp:Label ID="Label33" runat="server" CssClass="style68" Text="Capacidad"></asp:Label>
                <asp:Label ID="Label34" runat="server" CssClass="style69" Text="Marca"></asp:Label>
                <asp:Label ID="Label35" runat="server" CssClass="style70" Text="Placa"></asp:Label>
                <asp:TextBox ID="txtMarca" runat="server" CssClass="style71" height="16px" 
                    width="180px"></asp:TextBox>
                <asp:TextBox ID="txtCapacidad" runat="server" CssClass="style72" height="16px" 
                    width="180px"></asp:TextBox>
                <div class="style75" style="border: thin groove #C0C0C0">
                    <asp:Label ID="Label37" runat="server" CssClass="style76" Text="Cantidad"></asp:Label>
                    <asp:Label ID="Label38" runat="server" CssClass="style77" Text="Unidad"></asp:Label>
                    <asp:Label ID="Label39" runat="server" CssClass="style78" Text="Detalle"></asp:Label>
                    <asp:TextBox ID="txtCantidad" runat="server" CssClass="style79" height="16px"></asp:TextBox>
                    <asp:TextBox ID="txtUnidad" runat="server" CssClass="style80" height="16px" 
                        width="114px"></asp:TextBox>
                    <asp:TextBox ID="txtDetalle" runat="server" CssClass="style81" height="16px"></asp:TextBox>
                </div>
                <asp:Label ID="Label40" runat="server" CssClass="style85" Text="Apellidos"></asp:Label>
                <asp:TextBox ID="txtApellidos" runat="server" CssClass="style86" Height="16px" 
                    Width="180px"></asp:TextBox>
                <asp:Label ID="Label41" runat="server" CssClass="style87" Text="Nombres"></asp:Label>
                <asp:TextBox ID="txtNomTransportista" runat="server" CssClass="style88" 
                    Height="16px" Width="180px"></asp:TextBox>
                <asp:TextBox ID="txtFechaFinT" runat="server" CssClass="style95" Height="16px" 
                    Width="180px"></asp:TextBox>
                <asp:TextBox ID="txtValorCancelado" runat="server" CssClass="style90"></asp:TextBox>
                <asp:Label ID="Label42" runat="server" CssClass="style91" 
                    Text="Metros Cúbicos Facturados"></asp:Label>
            <asp:Label ID="Label43" runat="server" CssClass="style92" 
                Text="Valor Cancelado"></asp:Label>
                <asp:DropDownList ID="cbxNumeroGuia" runat="server" CssClass="style94" 
                    AutoPostBack="True" 
                    onselectedindexchanged="cbxNumeroGuia_SelectedIndexChanged" 
                    AppendDataBoundItems="True">
                </asp:DropDownList>
                <asp:TextBox ID="txtHoraDespacho" runat="server" CssClass="style96" 
                    Height="16px" Width="180px"></asp:TextBox>
                <asp:TextBox ID="txtApelTransportista" runat="server" CssClass="style97" 
                    Height="16px" Width="180px"></asp:TextBox>
                <asp:DropDownList ID="txtCedTransportista" runat="server" CssClass="style98" 
                    Height="22px" Width="186px" AutoPostBack="True" 
                    onselectedindexchanged="txtCedTransportista_SelectedIndexChanged" 
                    AppendDataBoundItems="True">
                </asp:DropDownList>
                <asp:DropDownList ID="txtPlaca" runat="server" CssClass="style99" 
                    Height="22px" Width="186px" AutoPostBack="True" 
                    onselectedindexchanged="txtPlaca_SelectedIndexChanged" 
                    AppendDataBoundItems="True">
                </asp:DropDownList>
                <asp:ImageButton ID="btnCedCliente" runat="server" CssClass="style102" 
                    onclick="ImageButton1_Click" ImageUrl="~/ima/lupa.png" />
            </div>
            <asp:Label ID="Label16" runat="server" CssClass="style38" Text="Fecha Factura"></asp:Label>
            <asp:TextBox ID="txtFechaFactura" runat="server" CssClass="style39" height="16px" 
                width="180px"></asp:TextBox>
            <asp:Label ID="Label25" runat="server" CssClass="style53" Text="Cédula/RUC"></asp:Label>
            <asp:TextBox ID="txtTelefonoCli" runat="server" CssClass="style56" Height="16px" 
                width="180px"></asp:TextBox>
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
        <asp:Button ID="btnImprimir" runat="server" CssClass="style37" height="33px" 
            Text="Imprimir" width="193px" onclick="btnImprimir_Click" />
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
        <asp:Button ID="btnNuevo" runat="server" CssClass="style101" Height="33px" 
            onclick="btnNuevo_Click" Text="Nuevo" Width="193px" />
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
        <asp:Button ID="btnSalir" runat="server" CssClass="style82" Height="33px" 
            Text="Salir" Width="193px" onclick="btnSalir_Click" />
        <br />
        <br />
        <br />
        <br />
        </strong>
        <asp:Label ID="lblMensaje" runat="server" CssClass="style93" Text="Mensaje"></asp:Label>
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

        function ValidDecimal(e) {
            var tecla = document.all ? tecla = e.keyCode : tecla = e.which;
            return ((tecla > 47 && tecla < 58) || tecla == 08 || tecla == 44 || tecla == 46);
        }

        function ValidCed(e) {
            var tecla = document.all ? tecla = e.keyCode : tecla = e.which;
            return ((tecla > 47 && tecla < 58) || tecla == 45 || tecla == 08);
        }

        function ValidPlaca(e) {
            var tecla = document.all ? tecla = e.keyCode : tecla = e.which;
            return ((tecla > 47 && tecla < 58) || (tecla > 64 && tecla < 91) || tecla == 45 || tecla == 08);
        }

        function ValidHora(e) {
            var tecla = document.all ? tecla = e.keyCode : tecla = e.which;
            return ((tecla > 47 && tecla < 58) || tecla == 08 || tecla == 58);
        }
               
        function ValidTel(e) {
            var tecla = document.all ? tecla = e.keyCode : tecla = e.which;
            return ((tecla > 47 && tecla < 58) || tecla == 08);
        }

        function ValidDom(e) {
            var tecla = document.all ? tecla = e.keyCode : tecla = e.which;
            return ((tecla > 64 && tecla < 91) || (tecla > 96 && tecla < 123) || (tecla > 47 && tecla < 58)
                    || (tecla > 159 || tecla < 164) || tecla == 130 || tecla == 181 || tecla == 144 || tecla == 214 || tecla == 224 || tecla == 233
                    || tecla == 08 || tecla == 35 || tecla == 32);
        }

        function ValidText(e) {
            var tecla = document.all ? tecla = e.keyCode : tecla = e.which;
            return ((tecla > 64 && tecla < 91) || (tecla > 96 && tecla < 123) || (tecla > 159 || tecla < 164)
                    || tecla == 130 || tecla == 181 || tecla == 144 || tecla == 214 || tecla == 224 || tecla == 233
                    || tecla == 08 || tecla == 32);
        }        
             

    </script>

</asp:Content>

