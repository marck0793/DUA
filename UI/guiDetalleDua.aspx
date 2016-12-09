<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="guiDetalleDua.aspx.cs" Inherits="UI.guiDetalleDua" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 789px; width: 1131px">
    <p>
        &nbsp;
    </p>
    <form id="form1" runat="server">
        <div style="height: 716px; width: 1299px;">

            <asp:Panel ID="Panel1" runat="server" Height="646px">
                <asp:Label ID="Label1" runat="server" Text="Numero de boleta: "></asp:Label>
                &nbsp;<asp:Label ID="lNumDetalleDua" runat="server" Text="Label"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
            <asp:Label ID="Label4" runat="server" Text="Modalidad"></asp:Label>
                &nbsp;&nbsp;
            <asp:Label ID="idModalidad" runat="server" Text="idModalidad"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label6" runat="server" Text="Aduana:   "></asp:Label>
                &nbsp;&nbsp;
            <asp:Label ID="idAduana" runat="server" Text="Label"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label3" runat="server" Text="Fecha:  "></asp:Label>
                &nbsp;&nbsp;
            <asp:TextBox ID="tbFechaD" runat="server"></asp:TextBox>
                &nbsp;
            <br />
                <br />
                <asp:Label ID="Label7" runat="server" Text="Nombre consignatario"></asp:Label>
                &nbsp;&nbsp;
            <asp:TextBox ID="tbNombreConsig" runat="server" Width="207px"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label8" runat="server" Text="Pais de origen"></asp:Label>
                &nbsp;&nbsp;
            <asp:DropDownList ID="ddlPaisOrigen" runat="server" Height="16px" Width="109px">
            </asp:DropDownList>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label9" runat="server" Text="Pais destino"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="DropDownList1" runat="server" Height="16px" Width="113px">
            </asp:DropDownList>
                <br />
                <br />
                <asp:Label ID="Label10" runat="server" Text="Puerto de embarque"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="DropDownList2" runat="server" Height="17px" Width="88px">
            </asp:DropDownList>
                &nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label11" runat="server" Text="Puerto de arribo"></asp:Label>
                &nbsp;&nbsp;&nbsp;<asp:DropDownList ID="DropDownList3" runat="server" Height="16px" Width="128px">
                </asp:DropDownList>
                &nbsp;&nbsp;&nbsp; &nbsp;
            <asp:Label ID="Label12" runat="server" Text="Puerto de salida"></asp:Label>
                &nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="DropDownList4" runat="server" Height="21px" Width="122px">
            </asp:DropDownList>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp; 
            <br />
                <br />
                <br />
                &nbsp;<asp:Label ID="Label13" runat="server" Text="Cantidad de bultos"></asp:Label>
                &nbsp;
            <asp:TextBox ID="tbcantBultos" runat="server" Width="91px">1</asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label14" runat="server" Text="Cantidad de  unidades"></asp:Label>
                &nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="DropDownList7" runat="server">
            </asp:DropDownList>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="tbCantUnidades" runat="server" Height="16px" Width="16px"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label15" runat="server" Text="Descripcion producto"></asp:Label>
                &nbsp;&nbsp;&nbsp;<asp:TextBox ID="tbDescripcionProducto" runat="server" Width="150px">1</asp:TextBox>
                &nbsp;&nbsp;&nbsp;
            <asp:Label ID="descProdDetall" runat="server" Text="descripcion prductoDetallado"></asp:Label>
                &nbsp;&nbsp;
            <asp:TextBox ID="tbPartidaArancel" runat="server" Width="75px"></asp:TextBox>
                <br />
                <br />
                &nbsp;
            <asp:Label ID="Label16" runat="server" Text="Partida Arancel"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="DropDownList6" runat="server" Height="16px" Width="135px">
            </asp:DropDownList>
                <br />
                <br />
                <br />
                &nbsp;<asp:Label ID="Label17" runat="server" Text="Valor del seguro"></asp:Label>
                &nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="tbValorseguro" runat="server" Style="margin-left: 0px" Width="92px">4</asp:TextBox>
                &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label18" runat="server" Text="Valor del flete"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="tbFlete" runat="server" Width="113px">4</asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label19" runat="server" Text="Valor otros"></asp:Label>
                &nbsp;&nbsp;&nbsp;<asp:TextBox ID="tbValorOtros" runat="server" Width="87px">4</asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label20" runat="server" Text="Valor de la factura"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="tbFactura" runat="server" Width="79px">4</asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
                <asp:Label ID="Label21" runat="server" Text="ValorAduaneroCIF_FOB"></asp:Label>
                &nbsp;&nbsp;
            <asp:TextBox ID="tbValorAduanero" runat="server">4</asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label22" runat="server" Text="ValorSeguroPesoBruto      "></asp:Label>
                &nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="tbSegPesoBruto" runat="server" Height="16px" Style="margin-left: 0px" Width="78px">4</asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label23" runat="server" Text="Peso neto"></asp:Label>
                <asp:TextBox ID="tbPesoNeto" runat="server" Style="margin-left: 27px">4</asp:TextBox>
                <br />
                <br />
                <asp:Label ID="Label24" runat="server" Text="Moneda"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:DropDownList ID="DropDownList5" runat="server" Height="16px" Style="margin-left: 0px" Width="59px">
                </asp:DropDownList>
                &nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label25" runat="server" Text="Tratado Conveno Internacional"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;<asp:DropDownList ID="DropDownList8" runat="server" Height="16px" Width="124px" OnSelectedIndexChanged="DropDownList8_SelectedIndexChanged">
                </asp:DropDownList>
                &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label26" runat="server" Text="Impuesto DAI"></asp:Label>
                &nbsp;&nbsp;&nbsp;<asp:TextBox ID="tbimpDAI" runat="server" Width="74px">4</asp:TextBox>
                &nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label27" runat="server" Text="Impuesto IFAM"></asp:Label>
                &nbsp;&nbsp;&nbsp;<asp:TextBox ID="tbImpIFAM" runat="server" Width="56px">4</asp:TextBox>
                &nbsp;&nbsp;
            <asp:Label ID="Label28" runat="server" Text="Impuesto LEY 7922"></asp:Label>
                &nbsp;&nbsp;<asp:TextBox ID="tbImp7922" runat="server" Width="62px">4</asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label29" runat="server" Text="Impuesto Ley 8114"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="tbImp8114" runat="server" Width="56px">4</asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label30" runat="server" Text="Impuesto Forestal"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="tbImpForestal" runat="server" Width="72px">4</asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label31" runat="server" Text="Impuesto Caldera"></asp:Label>
                &nbsp;&nbsp;&nbsp;<asp:TextBox ID="tbImpCaldera" runat="server" Width="80px">4</asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label32" runat="server" Text="Impuesto Ventas"></asp:Label>
                &nbsp;&nbsp;&nbsp;<asp:TextBox ID="tbImpVentas" runat="server" Width="77px">4</asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label33" runat="server" Text="Impuesto  Salvaguarda"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="tbImpSalvaguarda" runat="server" Width="62px">1</asp:TextBox>
                &nbsp; &nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
            <br />
                <asp:Label ID="Label34" runat="server" Text="Impuesto Gofito"></asp:Label>
                &nbsp;&nbsp; &nbsp;&nbsp;<asp:TextBox ID="tbImpGolfito" runat="server" Width="81px">4</asp:TextBox>
                &nbsp;&nbsp;
            <asp:Label ID="Label35" runat="server" Text="Codigo Exoneracion"></asp:Label>
                &nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="tbCodExoneracion" runat="server" Width="57px">4</asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label36" runat="server" Text="Exoneracion Selectivo Consumo"></asp:Label>
                &nbsp;&nbsp;<asp:TextBox ID="tbExonSelectCons" runat="server" Width="66px">4</asp:TextBox>
                &nbsp;&nbsp;
            <asp:Label ID="Label37" runat="server" Text="Exoneracion Ventas"></asp:Label>
                &nbsp;&nbsp;&nbsp;<asp:TextBox ID="tbExonVent" runat="server" Width="71px">4</asp:TextBox>
                &nbsp; &nbsp;
            <asp:Label ID="Label38" runat="server" Text="Condicion Entrega"></asp:Label>
                &nbsp;&nbsp;
            <asp:DropDownList ID="ddlCondEntrega" runat="server">
            </asp:DropDownList>
                &nbsp;
            <asp:Label ID="Label39" runat="server" Text="Pais de adquisicion "></asp:Label>
                <asp:DropDownList ID="ddlPaisAdq" runat="server" Style="margin-left: 78px">
                </asp:DropDownList>
                <br />
                &nbsp;<br />
                <asp:Button ID="Button2" runat="server" Height="24px" OnClick="Button1_Click" Text="+" Width="32px" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" Height="22px" OnClick="Button2_Click" Text="-" Width="33px" />
                &nbsp;&nbsp;&nbsp;
            <asp:GridView ID="GridView1" runat="server" AutoGenerateSelectButton="True" Width="531px">
            </asp:GridView>
                <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Guardar" style="height: 26px" />
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
            </asp:Panel>
            <br />
            <br />
            <br />
            <br />
            <br />

        </div>
    </form>
</body>
</html>
