using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CatalogoPlatillos
{
    public partial class LogIn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connection = ConfigurationManager.ConnectionStrings["CatalogoPlatillosConnectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(connection);
            SqlCommand cmd_host,cmd_query;
            cmd_host = new SqlCommand();
            cmd_query = new SqlCommand();
            cmd_host.CommandType = System.Data.CommandType.Text;
            cmd_query.CommandType = System.Data.CommandType.Text;
            cmd_host.CommandText = "update T_Usuarios set Host = '-'  where Host = HOST_NAME();";
            cmd_query.CommandText = "update T_Usuarios set Querys = '-' where Host = HOST_NAME();";
            cmd_host.Connection = con;
            cmd_query.Connection = con;
            con.Open();
            cmd_host.ExecuteNonQuery();
            con.Close();
            con.Open();
            cmd_query.ExecuteNonQuery();
            con.Close();

            
        }

        protected void btnEntrar_Click(object sender, EventArgs e)
        {
            string connection = ConfigurationManager.ConnectionStrings["CatalogoPlatillosConnectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand();
            SqlDataReader sqldr;
            cmd.CommandType = System.Data.CommandType.Text;
            String usuario = txtUsuario.Text;
            String password = txtPassword.Text;
            String query = "SELECT Usuario, Nombre,Password FROM T_Usuarios WHERE Usuario= '" + usuario + "' AND Password= '" + password + "'";
            cmd.CommandText = query;
            cmd.Connection = con;
            con.Open();
            sqldr = cmd.ExecuteReader();
            while (sqldr.Read())
            {
                Session["usuario"] = usuario;
                Session["name"] = sqldr["Nombre"].ToString();
                Response.Redirect("CapturaPlatillo.aspx");
            }
            lblMensaje.Text = "usuario o Password incorrectos";
        }
    }
}