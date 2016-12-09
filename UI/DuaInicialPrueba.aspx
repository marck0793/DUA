<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DuaInicialPrueba.aspx.cs" Inherits="UI.DuaInicialPrueba" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <p>
        <br />
    </p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <form id="form1" runat="server">
        <div>
    
            <br />
            <asp:Label ID="SCModalidad" runat="server" Text="Modalidad "></asp:Label>
            <asp:DropDownList ID="DropDownList2" runat="server" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged">
                <asp:ListItem Value="01">&#39;NORMAL  </asp:ListItem>
                <asp:ListItem Value="02">&#39;A GRANEL   </asp:ListItem>
                <asp:ListItem Value="04">&#39;GOLFITO</asp:ListItem>
                <asp:ListItem Value="05">DESPACHO DOMICILIARIO INDUSTRIAL    </asp:ListItem>
                <asp:ListItem Value="06">&#39;DESPACHO DOMICILIARIO COMERCIAL</asp:ListItem>
                <asp:ListItem Value="07">DEFINITIVA DE IMPORTACIÓN TEMPORAL        </asp:ListItem>
            </asp:DropDownList>
            <br />
            <asp:Label ID="idRegimen" runat="server" Text="Regimen"></asp:Label>
            <br />
            <asp:DropDownList ID="idModalidad" runat="server" AutoPostBack="True" Height="16px" OnSelectedIndexChanged="idModalidad_SelectedIndexChanged" style="margin-left: 39px" Width="312px">
                <asp:ListItem Value="00">Inactivación de Importador/Exportador</asp:ListItem>
                <asp:ListItem Value="01">Importación Definitiva</asp:ListItem>
                <asp:ListItem Value="04">Importación Temporal</asp:ListItem>
                <asp:ListItem Value="05">Reimportación</asp:ListItem>
                <asp:ListItem Value="06">Reimportación Perfeccionamiento Pasivo</asp:ListItem>
                <asp:ListItem Value="09">Zona Franca</asp:ListItem>
                <asp:ListItem Value="11">Perfeccionamiento Activo</asp:ListItem>
            </asp:DropDownList>
            <br />
            <asp:Label ID="idAduana" runat="server" Text="Aduana"></asp:Label>
            <br />
            <asp:DropDownList ID="DropDownList1" runat="server" style="margin-bottom: 0px">
                <asp:ListItem Value="001">Central</asp:ListItem>
                <asp:ListItem Value="002">&#39;Caldera</asp:ListItem>
                <asp:ListItem Value="003">&#39;Peñas Blancas</asp:ListItem>
                <asp:ListItem Value="004">Multimodal</asp:ListItem>
                <asp:ListItem Value="005">Santamaría (Las Cañas)</asp:ListItem>
                <asp:ListItem Value="006">&#39;Limón</asp:ListItem>
                <asp:ListItem Value="007">Paso Canoas</asp:ListItem>
            </asp:DropDownList>
            <br />
            <asp:Label ID="tipoIdentificacion" runat="server" Text="Tipo de identificacion "></asp:Label>
            <br />
            <asp:TextBox ID="tbCodigoModalidad" runat="server" OnTextChanged="tbCodigoModalidad_TextChanged"></asp:TextBox>
            <br />
            <asp:Label ID="idTransporte" runat="server" Text="Transporte"></asp:Label>
            <asp:DropDownList ID="DropDownList3" runat="server" style="margin-top: 49px; margin-left: 23px;">
                <asp:ListItem Value="1">Maritimo</asp:ListItem>
                <asp:ListItem Value="2">Fluvial</asp:ListItem>
                <asp:ListItem Value="3">Lacustre</asp:ListItem>
                <asp:ListItem Value="5">Aereo</asp:ListItem>
                <asp:ListItem Value="7">postal</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:Label ID="numIdentificacion" runat="server" Text="Numero de Identicicacion "></asp:Label>
            <br />
            <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Sumatoria Cantidad de Bultos"></asp:Label>
            <br />
            <asp:TextBox ID="sumatCantidadBultos" runat="server" OnTextChanged="sumatCantidadBultos_TextChanged"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="margin-left: 680px" Text="Button" Width="244px" />
            <br />
            <br />
            <br />
    
    </div>
    </form>
</body>
</html>
