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
    public partial class Alterar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void btnLimpar_Click(object sender, EventArgs e)
        {
            try
            {
                //limpa todos os TextBox
                txtNome.Text = "";
                txtAutor.Text = "";
                txtEditora.Text = "";
                txtGenero.Text = "";
                txtLingua.Text = "";
                txtPaginas.Text = "";
                txtAno.Text = "";
                txtEdicao.Text = "";
                txtIsbn.Text = "";
            }
            catch (Exception)
            {

                throw;
            }
        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                Livro l = new Livro();//instancia de um novo livro
                //obtem valores dos TextBox
                l.Nome = txtNome.Text;
                l.Autor = txtAutor.Text;
                l.Editora = txtEditora.Text;
                l.Genero = txtGenero.Text;
                l.Lingua = txtLingua.Text;
                l.Paginas = Convert.ToInt32(txtPaginas.Text);
                l.Ano = Convert.ToInt32(txtAno.Text);
                l.Edicao = Convert.ToInt32(txtEdicao.Text);
                l.Isbn = Convert.ToInt32(txtIsbn.Text);
                //grava no banco
                LivroDAL d = new LivroDAL();
                d.Alterar(l);
                //mensagem de confirmação
                lblMensagem.Text = "Livro Atualizado com Sucesso";
            }
            catch (Exception ex)
            {

                throw new Exception("Erro" + ex.Message);
            }
        }
    }
}