<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GuiBoleta.aspx.cs" Inherits="UI.GuiBoleta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <br />
        <br />
        <asp:Panel ID="Panel1" runat="server" Height="170px" Width="334px">
            <br />
            <br />
            <asp:Label ID="codigoBoleta" runat="server" Text="Codigo"></asp:Label>
            <asp:TextBox ID="codBoleta" runat="server" style="margin-left: 50px" Width="66px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Descripcion"></asp:Label>
            <asp:TextBox ID="descripBoleta" runat="server" Height="24px" style="margin-left: 20px" Width="228px"></asp:TextBox>
            <br />
            <asp:Button ID="btnBoleta" runat="server" OnClick="btnBoleta_Click" Text="Guardar" />
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </asp:Panel>
        <br />
        <br />
        <br />
        <br />
        <br />
    
    </div>
    </form>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
</body>
</html>
