<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ModificarDuaInicial.aspx.cs" Inherits="UI.ModificarDuaInicial" %>

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
    <form id="form1" runat="server">
    <div>
    
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Ingresar nuevo Dua" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    
        <asp:Button ID="bReportes" runat="server" OnClick="Button3_Click" Text="Reportes" />
        <br />
        <asp:Panel ID="Panel1" runat="server" BorderColor="#0066CC" Height="254px" Width="918px">
            <asp:Table ID="tListaDuaInicial" runat="server" Height="16px" Width="34px">
            </asp:Table>
            <asp:GridView ID="gvListaDuaInicial" runat="server" Height="16px" style="margin-top: 0px" Width="721px">
            </asp:GridView>
        </asp:Panel>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
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
    </form>
</body>
</html>
