using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;//referencia o pacote SqlClient do ADO.NET Framework

namespace BookSys.DataAccess
{
    //a classe recebe o modificador de acesso public, permitindo que a mesma seja acessada por outras classes
    public class Persistence
    {
        //seus atributos e funções são protected, permitindo que só sejam acessados quando herdados
        protected SqlCommand    Cmd;//classe responsável pelos comandos de DML
        protected SqlConnection Con;//classe responsável pela conexão com o banco
        protected SqlDataReader Dr; //classe responsável por fazer a leitura dos dados do banco
        
        //Método para abrir conexão com o banco
        protected void Conectar()
        {
            try
            {
                Con = new SqlConnection("Data Source=ADM\\SQLEXPRESS;Initial Catalog=db_booksys;Integrated Security=True");//Connection String, é o caminho para que a aplicação encontre o banco
                Con.Open();//abre a conexão com o banco
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //Método para fechar conexão com o banco
        protected void Desconetar()
        {
            try
            {
                Con.Close();//fecha a conexão com o banco
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

   }
}