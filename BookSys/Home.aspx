<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="BookSys.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 860px;
            height: 306px;
        }
    </style>
</head>
<body style="height: 427px">
    <form id="HomePage" runat="server" aria-orientation="horizontal">
    <div>
    
        <img alt="prateleira" class="auto-style1" src="Images/prateleira.jpg" /></div>
        <p>
            <asp:Label ID="lblOpcao" runat="server" Font-Bold="True" Font-Size="Large" Text="Opções:"></asp:Label>
        </p>
        <asp:DropDownList ID="ddlOpcao" runat="server" Height="32px" Width="294px">
            <asp:ListItem Value="0" Text="Selecione uma opção" />
            <asp:ListItem Value="1" Text="Cadastrar" />
            <asp:ListItem Value="2" Text="Consultar" />
            <asp:ListItem Value="3" Text="Alterar" />
            <asp:ListItem Value="4" Text="Excluir" />
        </asp:DropDownList>
        <asp:Button ID="btnEnviar" runat="server" Text="ENVIAR" Width="98px" Height="29px" OnClick="btnEnviar_Click" />
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p style="width: 632px; margin-left: 77px">
            &nbsp;</p>
        <p style="width: 632px; margin-left: 77px">
            &nbsp;</p>
        <p style="width: 632px; margin-left: 77px">
            <asp:Label ID="Label1" runat="server" Text="Trabalho criado pelos alunos do 3º semestre do curso de Tecnologia em Análise e Desenvolvimento de Sistemas
                 da faculdade Anhanguera de Campinas Unidade 1 - Como avaliação para as disciplinas
                 PROINTER e Linguagem de Programação Comercial, sob a coordenação e supervisão do Professor Ricardo." style="margin-left: 92px" Width="545px"></asp:Label>
        </p>
        <p style="width: 632px; margin-left: 77px">
            &nbsp;</p>
        <p style="width: 632px; margin-left: 77px">
            &nbsp;</p>
        <p style="width: 632px; margin-left: 77px">
            &nbsp;</p>
        <p style="width: 632px; margin-left: 77px">
            &nbsp;</p>
        <p style="width: 632px; margin-left: 77px">
            <asp:LinkButton ID="LinkButton" runat="server" OnClick="LinkButton_Click">About</asp:LinkButton>
        </p>
    </form>
</body>
</html>
