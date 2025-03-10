using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio2.DAL
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
            try
            {
                //Usar apenas no SENAC \/
                //conn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; Initial Catalog = Biblio2DB; Integrated Security = true");

                //Usar apenas em casa \/
                conn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; Initial Catalog = Biblio2DB; Integrated Security = true");


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
