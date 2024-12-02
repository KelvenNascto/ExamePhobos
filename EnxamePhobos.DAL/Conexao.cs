using System;
using System.Data.SqlClient;//

namespace EnxamePhobos.DAL
{
    public class Conexao
    {
        //campo de apoio
        protected SqlConnection conn;
        protected SqlCommand cmd;
        protected SqlDataReader dr;

        //procedimentos

        public void Conectar()
        {
            //escreva try e use tab + tab
            try
            {
                conn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; Initial Catalog = EnxamePhobosDB; Integrated Security = true");
                conn.Open();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public void Desconectar()
        {
            try
            {
                conn.Close();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

    }
}
