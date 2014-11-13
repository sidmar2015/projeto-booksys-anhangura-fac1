<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="BookSys.About" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 960px;
            height: 430px;
        }
        .auto-style2 {
            width: 150px;
            height: 116px;
            margin-left: 95px;
        }
        .auto-style3 {
            width: 247px;
            height: 73px;
            margin-left: 67px;
        }
        .auto-style4 {
            width: 200px;
            height: 143px;
            margin-left: 48px;
        }
        .auto-style5 {
            width: 544px;
            height: 200px;
            margin-left: 211px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <img alt="" class="auto-style1" src="Images/prateleira.jpg" /></div>
        <p>
            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Home</asp:LinkButton>
        </p>
        <p>
            <img alt="" class="auto-style2" src="Imagens/logo-anhanguera.jpg" /><img alt="" class="auto-style3" src="Imagens/csharpdotnet.jpg" /><img alt="" class="auto-style4" src="Imagens/SQL_Server_Logo_svg.jpg" /></p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="Label1" runat="server" Text="Sidmar Porfírio RA 7989711257           Leonardo Félix Cuencas RA 7700620660                                    Marcos Renato Falconi   RA    7980703924" style="margin-left: 142px" Width="406px" Font-Size="X-Large"></asp:Label>
        </p>
    </form>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        <img alt="" class="auto-style5" src="Imagens/logo_booksys.jpg" /></p>
</body>
</html>
