using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace CatalogoPlatillos
{
    public partial class ModificarPedido : System.Web.UI.Page
    {
        string Query = "";
        //funciones
        private void fuction_trigger(string query)
        {
            string connection = ConfigurationManager.ConnectionStrings["CatalogoPlatillosConnectionString"].ConnectionString;
            SqlConnection Con = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = String.Format("Update T_Usuarios set Querys = {1},Host = Host_Name() where Usuario = {0}",Session["usuario"].ToString(),query);
            cmd.Connection = Con;
            Con.Open();
            cmd.ExecuteNonQuery();
            Con.Close();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            Query = "";
            if (Session["usuario"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            if (!@Page.IsPostBack)
            {
                string connection = ConfigurationManager.ConnectionStrings["CatalogoPlatillosConnectionString"].ConnectionString;
                SqlConnection con = new SqlConnection(connection);
                SqlCommand cmd = new SqlCommand();
                SqlDataReader sqldr;
                cmd.CommandType = System.Data.CommandType.Text;
                String ID = Request["ID"];
                cmd.CommandText = Query;
                cmd.Connection = con;
                con.Open();
                sqldr = cmd.ExecuteReader();
                while (sqldr.Read())
                {
                    TxtNombreCliente.Text = sqldr["CLIENTE"].ToString();
                    txtDireccion.Text = sqldr["DIRECCION"].ToString();
                    txtCategoria.Text = sqldr["CATEGORIA"].ToString();
                    TxtDescripcion.Text = sqldr["Descripcion"].ToString();
                }
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
        }
    }
}