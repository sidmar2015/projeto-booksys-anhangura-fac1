using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BookSys.DataAccess;
using BookSys.Model;

namespace BookSys
{
    public partial class Excluir : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Home.aspx");//redireciona para a página principal
        }

        protected void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                int codigo = Convert.ToInt32(txtExcluir.Text);//converte o conteúdo do TextBox para passar como argumento para o método excluir
                LivroDAL d = new LivroDAL();
                d.Excluir(codigo);//exclui o livro pelo código digitado
                Response.Redirect("/Excluir.aspx");//efetua um refresh na página
            }
            catch (Exception ex)
            {
                
                throw new Exception(ex.Message);
            }
        }
    }
}