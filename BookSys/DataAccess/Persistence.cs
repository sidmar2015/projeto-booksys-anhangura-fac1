using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace BookSys.DataAccess
{
    public class Persistence
    {
        protected SqlCommand    Cmd;
        protected SqlConnection Con;
        protected SqlDataReader Dr;
        
        //Método para abrir conexão com o banco
        protected void Conectar()
        {
            try
            {
                Con = new SqlConnection("Data Source=ADM\\SQLEXPRESS;Initial Catalog=db_booksys;Integrated Security=True");//Connection String
                Con.Open();
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
                Con.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

   }
}