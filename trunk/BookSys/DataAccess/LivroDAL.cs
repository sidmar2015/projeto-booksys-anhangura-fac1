using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using BookSys.Model;

namespace BookSys.DataAccess
{
    public class LivroDAL : Persistence
    {
        //Cadastrar Livro - Insert
        public void Cadastrar(Livro l)
        {
            try
            {
                Conectar();
                //Script do insert
               
                Cmd = new SqlCommand("insert into tb_livro (nome, autor, editora, genero, lingua, paginas, ano, edicao, isbn)values(@nome, @autor, @editora, @genero, @lingua, @paginas, @ano, @edicao, @isbn)",Con);
                Cmd.Parameters.AddWithValue("@nome",l.Nome);
                Cmd.Parameters.AddWithValue("@autor", l.Autor);
                Cmd.Parameters.AddWithValue("@editora", l.Editora);
                Cmd.Parameters.AddWithValue("@genero", l.Genero);
                Cmd.Parameters.AddWithValue("@lingua", l.Lingua);
                Cmd.Parameters.AddWithValue("@paginas", l.Paginas);
                Cmd.Parameters.AddWithValue("@ano", l.Ano);
                Cmd.Parameters.AddWithValue("@edicao", l.Edicao);
                Cmd.Parameters.AddWithValue("@isbn", l.Isbn);
                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception(" ao Gravar Livro: " + ex.Message);
            }
            finally
            {
                Desconetar();
            }
        }
        //Consultar todos os livros cadastrados - Select * from...
        public List<Livro> ConsultarTudo()
        {
            try
            {
                Conectar();
                Cmd = new SqlCommand("select * from tb_livro",Con);

                Dr = Cmd.ExecuteReader();
                List<Livro> lista = new List<Livro>();//cria uma lista vazia

                while (Dr.Read())
                {
                    Livro l = new Livro();//cria a instancia do livro
                    //recupera os valores lidos da base de dados
                    l.Id = Convert.ToInt32(Dr["id"]);
                    l.Nome = Convert.ToString(Dr["nome"]);
                    l.Autor = Convert.ToString(Dr["autor"]);
                    l.Editora = Convert.ToString(Dr["editora"]);
                    l.Genero = Convert.ToString(Dr["genero"]);
                    l.Lingua = Convert.ToString(Dr["lingua"]);
                    l.Paginas = Convert.ToInt32(Dr["paginas"]);
                    l.Ano = Convert.ToInt32(Dr["ano"]);
                    l.Edicao = Convert.ToInt32(Dr["edicao"]);
                    l.Isbn = Convert.ToInt32(Dr["isbn"]);
                    //adiciona a lista
                    lista.Add(l);
                 }
                return lista;
             }
            catch (Exception ex)
            {

                throw new Exception(" Nada foi encontrado" + ex.Message);
            }
            finally
            {
                Desconetar();
            }
        }
        //Consultar por nome
        public List<Livro> ConsultarNome(string nome)
        {
            try
            {
                Conectar();
                Cmd = new SqlCommand("select * from tb_livro where nome=@nome", Con);
                Cmd.Parameters.AddWithValue("@nome", nome);

                Dr = Cmd.ExecuteReader();
                List<Livro> lista = new List<Livro>();//cria uma lista vazia

                while (Dr.Read())
                {
                    Livro l = new Livro();//cria a instancia do livro
                    //recupera os valores lidos da base de dados
                    l.Id = Convert.ToInt32(Dr["id"]);
                    l.Nome = Convert.ToString(Dr["nome"]);
                    l.Autor = Convert.ToString(Dr["autor"]);
                    l.Editora = Convert.ToString(Dr["editora"]);
                    l.Genero = Convert.ToString(Dr["genero"]);
                    l.Lingua = Convert.ToString(Dr["lingua"]);
                    l.Paginas = Convert.ToInt32(Dr["paginas"]);
                    l.Ano = Convert.ToInt32(Dr["ano"]);
                    l.Edicao = Convert.ToInt32(Dr["edicao"]);
                    l.Isbn = Convert.ToInt32(Dr["isbn"]);
                    //adiciona a lista
                    lista.Add(l);
                }
                return lista;
            }
            catch (Exception ex)
            {

                throw new Exception("Nada foi encontrado" + ex.Message);
            }
            finally
            {
                Desconetar();
            }
        }
        //Consultar por autor
        public List<Livro> ConsultarAutor(string autor)
        {
            try
            {
                Conectar();
                Cmd = new SqlCommand("select * from tb_livro where autor=@autor", Con);
                Cmd.Parameters.AddWithValue("@autor", autor);

                Dr = Cmd.ExecuteReader();
                List<Livro> lista = new List<Livro>();//cria uma lista vazia

                while (Dr.Read())
                {
                    Livro l = new Livro();//cria a instancia do livro
                    //recupera os valores lidos da base de dados
                    l.Id = Convert.ToInt32(Dr["id"]);
                    l.Nome = Convert.ToString(Dr["nome"]);
                    l.Autor = Convert.ToString(Dr["autor"]);
                    l.Editora = Convert.ToString(Dr["editora"]);
                    l.Genero = Convert.ToString(Dr["genero"]);
                    l.Lingua = Convert.ToString(Dr["lingua"]);
                    l.Paginas = Convert.ToInt32(Dr["paginas"]);
                    l.Ano = Convert.ToInt32(Dr["ano"]);
                    l.Edicao = Convert.ToInt32(Dr["edicao"]);
                    l.Isbn = Convert.ToInt32(Dr["isbn"]);
                    //adiciona a lista
                    lista.Add(l);
                }
                return lista;
            }
            catch (Exception ex)
            {

                throw new Exception("Nada foi encontrado" + ex.Message);
            }
            finally
            {
                Desconetar();
            }
        }
        //consultar por editora
        public List<Livro> ConsultarEditora(string editora)
        {
            try
            {
                Conectar();
                Cmd = new SqlCommand("select * from tb_livro where editora=@editora", Con);
                Cmd.Parameters.AddWithValue("@editora", editora);

                Dr = Cmd.ExecuteReader();
                List<Livro> lista = new List<Livro>();//cria uma lista vazia

                while (Dr.Read())
                {
                    Livro l = new Livro();//cria a instancia do livro
                    //recupera os valores lidos da base de dados
                    l.Id = Convert.ToInt32(Dr["id"]);
                    l.Nome = Convert.ToString(Dr["nome"]);
                    l.Autor = Convert.ToString(Dr["autor"]);
                    l.Editora = Convert.ToString(Dr["editora"]);
                    l.Genero = Convert.ToString(Dr["genero"]);
                    l.Lingua = Convert.ToString(Dr["lingua"]);
                    l.Paginas = Convert.ToInt32(Dr["paginas"]);
                    l.Ano = Convert.ToInt32(Dr["ano"]);
                    l.Edicao = Convert.ToInt32(Dr["edicao"]);
                    l.Isbn = Convert.ToInt32(Dr["isbn"]);
                    //adiciona a lista
                    lista.Add(l);
                }
                return lista;
            }
            catch (Exception ex)
            {

                throw new Exception("Nada foi encontrado" + ex.Message);
            }
            finally
            {
                Desconetar();
            }
        }

        //Consultar por ISBN
        public List<Livro> ConsultarIsbn(int isbn)
        {
            try
            {
                Conectar();
                Cmd = new SqlCommand("select * from tb_livro where isbn=@isbn", Con);
                Cmd.Parameters.AddWithValue("@isbn", isbn);

                Dr = Cmd.ExecuteReader();
                List<Livro> lista = new List<Livro>();//cria uma lista vazia

                while (Dr.Read())
                {
                    Livro l = new Livro();//cria a instancia do livro
                    //recupera os valores lidos da base de dados
                    l.Id = Convert.ToInt32(Dr["id"]);
                    l.Nome = Convert.ToString(Dr["nome"]);
                    l.Autor = Convert.ToString(Dr["autor"]);
                    l.Editora = Convert.ToString(Dr["editora"]);
                    l.Genero = Convert.ToString(Dr["genero"]);
                    l.Lingua = Convert.ToString(Dr["lingua"]);
                    l.Paginas = Convert.ToInt32(Dr["paginas"]);
                    l.Ano = Convert.ToInt32(Dr["ano"]);
                    l.Edicao = Convert.ToInt32(Dr["edicao"]);
                    l.Isbn = Convert.ToInt32(Dr["isbn"]);
                    //adiciona a lista
                    lista.Add(l);
                }
                return lista;
            }
            catch (Exception ex)
            {

                throw new Exception("Nada foi encontrado" + ex.Message);
            }
            finally
            {
                Desconetar();
            }
        }
        //Excluir livro - Delete
        public void Excluir(int Id)
        {
            try
            {
                Conectar();
                Cmd = new SqlCommand("delete from tb_livro where id=@id",Con);
                Cmd.Parameters.AddWithValue("@id",Id);
                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception("Não foi possível excluir o livro: " + ex.Message);
            }
            finally
            {
                Desconetar();
            }
        }
        //Atualizar dados - Update
        public void Alterar(Livro l)
        {
            try
            {
                Conectar();
                Cmd = new SqlCommand("update tb_livro set nome=@nome, autor=@autor, editora=@editora, genero=@genero, lingua=@lingua, paginas=@paginas, ano=@ano, edicao=@edicao, isbn=@isbn where nome=@nome", Con);
                Cmd.Parameters.AddWithValue("@nome", l.Nome);
                Cmd.Parameters.AddWithValue("@autor", l.Autor);
                Cmd.Parameters.AddWithValue("@editora", l.Editora);
                Cmd.Parameters.AddWithValue("@genero", l.Genero);
                Cmd.Parameters.AddWithValue("@lingua", l.Lingua);
                Cmd.Parameters.AddWithValue("@paginas", l.Paginas);
                Cmd.Parameters.AddWithValue("@ano", l.Ano);
                Cmd.Parameters.AddWithValue("@edicao", l.Edicao);
                Cmd.Parameters.AddWithValue("@isbn", l.Isbn);
                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception("Não foi possível atualizar o livro: " +ex.Message);
            }
            finally
            {
                Desconetar();
            }
        }

    }
}