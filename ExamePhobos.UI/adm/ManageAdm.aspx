<%@ Page Title="" Language="C#" MasterPageFile="~/adm/DefaultAdm.Master" AutoEventWireup="true" CodeBehind="ManageAdm.aspx.cs" Inherits="ExamePhobos.UI.adm.ManageAdm" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%--formulario--%>
    <ul>
        <li>
            <asp:TextBox ID="txtIdUsuario" placeholder="Id:" runat="server"></asp:TextBox>
        </li>
        <li>
            <asp:TextBox ID="txtNomeUsuario" MaxLength="150" placeholder="Nome:" runat="server"></asp:TextBox>
            <asp:Label ID="lblNomeUsuario" runat="server" Text=""></asp:Label>
        </li>
        <li>
            <asp:TextBox ID="txtEmailUsuario" MaxLength="150" placeholder="Email:" runat="server"></asp:TextBox>
            <asp:Label ID="lblEmailUsuario" runat="server" Text=""></asp:Label>

        </li>
        <li>
            <asp:TextBox ID="txtSenhaUsuario" MaxLength="6" placeholder="Senha:" runat="server"></asp:TextBox>
            <asp:Label ID="lblSenhaUsuario" runat="server" Text=""></asp:Label>

        </li>
        <li>
            <asp:TextBox ID="txtDtNascUsuario" placeholder="Data Nasc:" onkeypress="$(this).mask('00/00/0000')" runat="server"></asp:TextBox>
            <asp:Label ID="lblDtNascUsuario" runat="server" Text=""></asp:Label>
        </li>
        <li>
            <asp:DropDownList
                ID="ddl1"
                Width="160px"
                Height="27px"
                AutoPostBack="false"
                DataValueField="IdTipoUsuario"
                DataTextField="DescricaoTipoUsuario"
                runat="server">
            </asp:DropDownList>
        </li>
        <li>
            <asp:Button ID="btnRecord" runat="server" Text="Record" OnClick="btnRecord_Click" />
            <asp:Button ID="btnClear" runat="server" Text="Clear" OnClick="btnClear_Click" />
            <asp:Button ID="btnDelete" runat="server" OnClientClick="if(!confirm('Deseja realmente eliminar este registro?'))return false" Text="Delete" OnClick="btnDelete_Click" />
        </li>
        <li>
            <asp:TextBox ID="txtSearch" placeholder="Search by name:" runat="server"></asp:TextBox>
            <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" />
            <asp:Label ID="lblSearch" runat="server" Text=""></asp:Label>

        </li>
    </ul>

    <asp:GridView ID="gv1" runat="server" OnSelectedIndexChanged="gv1_SelectedIndexChanged" AutoGenerateColumns="false">
        <Columns>
            <asp:CommandField ShowSelectButton="true" ButtonType="Button" HeaderText="Options" />
            <asp:BoundField DataField="IdUsuario" HeaderText="Código" />
            <asp:BoundField DataField="EmailUsuario" HeaderText="Email" />
            <asp:BoundField DataField="SenhaUsuario" HeaderText="Senha" />
            <asp:BoundField DataField="DtNascUsuario" HeaderText="Data Nascimento" DataFormatString="{0:dd/MM/yyyy}" />
            <asp:BoundField DataField="UsuarioTp" HeaderText="Permissão" />
        </Columns>
    </asp:GridView>
    <asp:GridView ID="GridView7" runat="server">

    </asp:GridView>
</asp:Content>
