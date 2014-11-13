using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BookSys.Model;
using BookSys.DataAccess;

namespace BookSys
{
    public partial class Consultar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnPesquisar_Click1(object sender, EventArgs e)
        {
            try
            {
                LivroDAL d = new LivroDAL();
                string escolha = ddlOpcao1.SelectedValue;

                switch (escolha)
                {
                    case "0":
                        break;
                    case "1":
                        //Consultar tudo
                        
                        gdvConsulta.DataSource = d.ConsultarTudo();
                        gdvConsulta.DataBind();
                        break;
                    case "2":
                        //consultar por Nome
                        gdvConsulta.DataSource = d.ConsultarNome(txtPesquisar.Text);
                        gdvConsulta.DataBind();
                        break;
                    case "3":
                        //consultar por Autor
                        gdvConsulta.DataSource = d.ConsultarAutor(txtPesquisar.Text);
                        gdvConsulta.DataBind();
                        break;
                    case "4":
                        //consultar por Editora
                        gdvConsulta.DataSource = d.ConsultarEditora(txtPesquisar.Text);
                        gdvConsulta.DataBind();
                        break;
                    case "5":
                        //consultar por ISBN
                        gdvConsulta.DataSource = d.ConsultarIsbn(Convert.ToInt32(txtPesquisar.Text));
                        gdvConsulta.DataBind();
                        break;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}