using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ejemplo_1_WebApp
{
    public partial class main : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed2_Click(object sender, EventArgs e)
        {
            EstudianteDLL manejodb = new EstudianteDLL();
            
            string Query_Crear = "create database "+txtbasedatos.Text;

            string user = Session["USER"].ToString();
            string pass = Session["PASS"].ToString();

            try
            {
                manejodb.conectar(user,pass);
                manejodb.EjecutarSQL(Query_Crear);
                manejodb.Desconectar();
                System.Web.UI.ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "AlertBox", "alert('Exito se creo');", true);
            }
            catch (Exception ex)
            {
                //System.Web.UI.ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "AlertBox", "alert('No se creo');", true);
                Response.Write("<script language=javascript>console.log('" + ex.ToString() + "'); </script>");
                //throw;
            }

            
        }
    }
}