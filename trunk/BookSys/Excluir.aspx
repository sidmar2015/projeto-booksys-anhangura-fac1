<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Excluir.aspx.cs" Inherits="BookSys.Excluir" %>

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
        <asp:Label ID="lblExcluir" runat="server" Text="Digite o código do livro:"></asp:Label>
        <asp:TextBox ID="txtExcluir" runat="server" Height="25px" Width="74px"></asp:TextBox>
        <asp:Button ID="btnExcluir" runat="server" Height="31px" OnClick="btnExcluir_Click" Text="EXCLUIR" Width="76px" />
        <asp:Button ID="btnCancelar" runat="server" Height="30px" OnClick="btnCancelar_Click" Text="CANCELAR" Width="95px" />
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:db_booksysConnectionString %>" SelectCommand="SELECT * FROM [tb_livro]"></asp:SqlDataSource>
        <asp:GridView ID="gdvConsulta" runat="server" Width="969px" AutoGenerateColumns="False" DataKeyNames="id" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True" SortExpression="id" />
                <asp:BoundField DataField="nome" HeaderText="nome" SortExpression="nome" />
                <asp:BoundField DataField="autor" HeaderText="autor" SortExpression="autor" />
                <asp:BoundField DataField="editora" HeaderText="editora" SortExpression="editora" />
                <asp:BoundField DataField="genero" HeaderText="genero" SortExpression="genero" />
                <asp:BoundField DataField="lingua" HeaderText="lingua" SortExpression="lingua" />
                <asp:BoundField DataField="paginas" HeaderText="paginas" SortExpression="paginas" />
                <asp:BoundField DataField="ano" HeaderText="ano" SortExpression="ano" />
                <asp:BoundField DataField="edicao" HeaderText="edicao" SortExpression="edicao" />
                <asp:BoundField DataField="isbn" HeaderText="isbn" SortExpression="isbn" />
            </Columns>
        </asp:GridView>
    </form>
</body>
</html>