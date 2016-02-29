using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Ejemplo_1_WebApp
{
    public class EstudianteDLL
    {
        public string user;
        public string pass ;

        public SqlConnection MiConexion;
        

        public void conectar(string usuario , string password)
        {
            user = usuario;
            pass = password;
            
            //MiConexionComplete = "Data Source=GALINDO-PC;Initial Catalog=master;User ID='" + usuario + "';Password='" + password + "'";
            MiConexion = new SqlConnection("Data Source=GALINDO-PC;Initial Catalog=master;User ID='"+user+"';Password='"+pass+"'");
            MiConexion.Open();
           
        }

        

      
        public void EjecutarSQL(String Query)
        {
            SqlCommand MiComando = new SqlCommand(Query, this.MiConexion);
            MiComando.ExecuteNonQuery();

        }

        public void Desconectar()
        {
            MiConexion.Close();
        }

       
        /*
        SqlConnection MiConexion;
        SqlCommand comando;
        SqlDataAdapter da;
        DataSet ds;

        public EstudianteDLL() {
            MiConexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
        }

        public void Insertar_Estudiante(string nombre,string ciudad,string codigo) {

            comando = new SqlCommand("insert into estudiantes values  (@name,@ciudad,@cod)",MiConexion);
            comando.Parameters.AddWithValue("@name", nombre);
            comando.Parameters.AddWithValue("@ciudad", ciudad);
            comando.Parameters.AddWithValue("@cod", codigo);
            
            MiConexion.Open();

            comando.ExecuteNonQuery();

            MiConexion.Close();
        }*/

    }
}