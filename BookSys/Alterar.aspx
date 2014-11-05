<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Alterar.aspx.cs" Inherits="BookSys.Alterar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="HomePage" runat="server" aria-orientation="horizontal">
    <div>
    
        <img alt="prateleira" class="auto-style1" src="Images/prateleira.jpg" /><asp:Image ID="Image1" runat="server" ImageAlign="Middle" />
    
        <p>
            <asp:Label ID="Label1" runat="server" Text="Nome"></asp:Label>
            <asp:TextBox ID="txtNome" runat="server" style="margin-left: 10px" Width="394px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Autor"></asp:Label>
            <asp:TextBox ID="txtAutor" runat="server" Width="317px" style="margin-left: 11px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label3" runat="server" Text="Editora"></asp:Label>
            <asp:TextBox ID="txtEditora" runat="server" Width="302px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label4" runat="server" Text="Gênero"></asp:Label>
            <asp:TextBox ID="txtGenero" runat="server" Width="124px"></asp:TextBox>
            <asp:Label ID="Label5" runat="server" Text="Língua"></asp:Label>
            <asp:TextBox ID="txtLingua" runat="server" style="margin-left: 16px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label6" runat="server" Text="Páginas"></asp:Label>
            <asp:TextBox ID="txtPaginas" runat="server" Width="34px"></asp:TextBox>
            <asp:Label ID="Label7" runat="server" Text="Ano"></asp:Label>
            <asp:TextBox ID="txtAno" runat="server" style="margin-left: 16px" Width="36px"></asp:TextBox>
            <asp:Label ID="Label8" runat="server" Text="Edição"></asp:Label>
            <asp:TextBox ID="txtEdicao" runat="server" style="margin-left: 16px" Width="32px"></asp:TextBox>
            <asp:Label ID="Label9" runat="server" Text="ISBN"></asp:Label>
            <asp:TextBox ID="txtIsbn" runat="server" Width="127px"></asp:TextBox>
        </p>
        <asp:Label ID="lblMensagem" runat="server" ForeColor="#00CC00"></asp:Label>
        <asp:Button ID="btnLimpar" runat="server" style="margin-left: 174px" Text="LIMPAR" Width="82px" OnClick="btnLimpar_Click" />
        <asp:Button ID="btnCadastrar" runat="server" Text="ATUALIZAR" Width="101px" OnClick="btnCadastrar_Click" />
    
    </div>
    </form>
</body>
</html>
