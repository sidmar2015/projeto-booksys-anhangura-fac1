using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BookSys;

namespace BookSys
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            string escolha = ddlOpcao.SelectedValue;//a string escolha recebe o valor refente a opção escolhida no Drop Down List

            switch (escolha)
            {
                case "0":
                    break;
                case "1":
                    Response.Redirect("/Cadastrar.aspx");//redireciona para a página de cadastro
                    break;
                case "2":
                    Response.Redirect("/Consultar.aspx");//redireciona para a página de consulta
                    break;
                case "3":
                    Response.Redirect("/Alterar.aspx");//redireciona para a página de alteração
                    break;
                case "4":
                    Response.Redirect("/Excluir.aspx");//redireciona para a página de exclusão
                    break;
                default:
                    break;
            }

        }

        protected void LinkButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("/About.aspx");//redireciona para a página about
        }

      

               
    }
}