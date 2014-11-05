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
            string escolha = ddlOpcao.SelectedValue;

            switch (escolha)
            {
                case "0":
                    break;
                case "1":
                    Response.Redirect("/Cadastrar.aspx");
                    break;
                case "2":
                    Response.Redirect("/Consultar.aspx");
                    break;
                case "3":
                    Response.Redirect("/Alterar.aspx");
                    break;
                case "4":
                    Response.Redirect("/Excluir.aspx");
                    break;
                default:
                    break;
            }

        }

        protected void LinkButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("/About.aspx");
        }

      

               
    }
}