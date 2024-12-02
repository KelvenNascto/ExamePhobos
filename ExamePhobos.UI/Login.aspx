<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ExamePhobos.UI.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="css/Style.css" rel="stylesheet" />
    <title>AUTENTICAÇÃO</title>
</head>
<body>
    <form id="form1" runat="server">
        <ul class ="Login">
           <%-- ctrl + alt + x--%>
            <li><h1>Autenticação</h1></li>
            <li>
                <asp:TextBox ID="txtNome" runat="server" Placeholder="Nome:" MaxLength="150"></asp:TextBox>
            </li>
            <li>
                <asp:TextBox ID="txtSenha" runat="server" Placeholder="Senha:" MaxLength="6"></asp:TextBox>
            </li>
            <li>
                <asp:Button ID="btnEntrar" runat="server" Text="Entra" OnClick="btnEntrar_Click"/>
                <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" OnClick="btnCancelar_Click"/>
            </li>
            <li>
                <asp:Label ID="lblResult" runat="server"></asp:Label>
            </li>
        </ul>
    </form>
</body>
</html>
