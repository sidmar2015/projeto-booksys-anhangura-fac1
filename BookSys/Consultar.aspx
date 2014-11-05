<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Consultar.aspx.cs" Inherits="BookSys.Consultar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="HomePage" runat="server" aria-orientation="horizontal">
    <div>
    
        <img alt="prateleira" class="auto-style1" src="Images/prateleira.jpg" /><asp:Image ID="Image1" runat="server" ImageAlign="Middle" />
    
    </div>
        <asp:Label ID="Label1" runat="server" Text="Consultar por:"></asp:Label>
        <asp:DropDownList ID="ddlOpcao1" runat="server" Height="25px" Width="202px">
            <asp:ListItem Value="0">Selecione uma opção</asp:ListItem>
            <asp:ListItem Value="1">Tudo</asp:ListItem>
            <asp:ListItem Value="2">Nome</asp:ListItem>
            <asp:ListItem Value="3">Autor</asp:ListItem>
            <asp:ListItem Value="4">Editora</asp:ListItem>
            <asp:ListItem Value="5">ISBN</asp:ListItem>
        </asp:DropDownList>
        <p>
            <asp:TextBox ID="txtPesquisar" runat="server" Width="222px" Height="25px"></asp:TextBox>
            <asp:Button ID="btnPesquisar" runat="server" Height="29px" OnClick="btnPesquisar_Click1" Text="PESQUISAR" Width="107px" />
        </p>
        <asp:GridView ID="gdvConsulta" runat="server" Width="969px">
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:db_booksysConnectionString %>" SelectCommand="SELECT * FROM [tb_livro]"></asp:SqlDataSource>
    </form>
</body>
</html>
