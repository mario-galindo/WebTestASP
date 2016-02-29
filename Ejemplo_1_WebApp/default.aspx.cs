using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ejemplo_1_WebApp
{
    public partial class _default : System.Web.UI.Page

        
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnInsertar_Click(object sender, EventArgs e)
        {
             EstudianteDLL myconexion = new EstudianteDLL();

             Session["USER"] = txtusuario.Text;
             Session["PASS"] = txtpassword.Text;

           
               try
                {
                    myconexion.conectar(txtusuario.Text,txtpassword.Text);
                   
                    System.Web.UI.ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "AlertBox", "alert('Felicidades se conecto');", true);
                    Response.Redirect("main.aspx");
                }
                catch (Exception ex)
                {
                    System.Web.UI.ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "AlertBox", "alert('error');", true);
                    Response.Write("<script language=javascript>console.log('" + ex.ToString() + "'); </script>");
                    //throw;
                }
            
            
           
        }
    }
}