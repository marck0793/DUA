<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="UI.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <br />
        <asp:Label ID="Label1" runat="server" Text="Nombre"></asp:Label>
        <br />
        <asp:TextBox ID="txtUsuario" runat="server" Height="22px" Width="127px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblAlerta" runat="server" Text="Contrasena"></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="txtClave" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Verificar" />
        <br />
    
    </div>
    </form>
</body>
</html>
