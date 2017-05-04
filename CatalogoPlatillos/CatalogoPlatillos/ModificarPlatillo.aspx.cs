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
    public partial class ModificarPlatillo : System.Web.UI.Page
    {
        string Query = "";
        //funciones
        private void fuction_trigger(string query)
        {
            string connection = ConfigurationManager.ConnectionStrings["CatalogoPlatillosConnectionString"].ConnectionString;
            SqlConnection Con = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = String.Format("Update T_Usuarios set Querys = '{0}',Host = Host_Name() where Usuario = '{1}'",
                query.Replace("'","''"),
                Session["usuario"].ToString());
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
                String ID = Request["ID"];
                Query = "Select Nombre_Platillo,Categoria,Precio,Descripcion from T_Platillos where NumPlatillos = "+ ID;
                string connection = ConfigurationManager.ConnectionStrings["CatalogoPlatillosConnectionString"].ConnectionString;
                SqlConnection con = new SqlConnection(connection);
                SqlCommand cmd = new SqlCommand();
                SqlDataReader sqldr;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = Query;
                cmd.Connection = con;
                con.Open();
                sqldr = cmd.ExecuteReader();
                while (sqldr.Read())
                {
                    TxtNombrePlatillo.Text = sqldr["Nombre_Platillo"].ToString();
                    ddlcategoria.SelectedValue = sqldr["Categoria"].ToString();
                    TxtPrecio.Text = sqldr["Precio"].ToString();
                    TxtDescripcion.Text = sqldr["Descripcion"].ToString();
                }
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            Query = String.Format("UPDATE T_Platillos SET Nombre_Platillo = '{0}', Categoria = '{1}', PRECIO = '{2}', DESCRIPCION = '{3}' WHERE NumPlatillos = '{4}'",
                TxtNombrePlatillo.Text,
                ddlcategoria.SelectedValue,
                TxtPrecio.Text,TxtDescripcion.Text,
                Request["ID"].ToString());

            fuction_trigger(Query);
            string connection = ConfigurationManager.ConnectionStrings["CatalogoPlatillosConnectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = Query;
            cmd.Connection = con;
            con.Open();
            cmd.ExecuteReader();
            con.Close();
            Response.Redirect("ConsultarPlatillos.aspx");
        }

        protected void btnBorrar_Click(object sender, EventArgs e)
        {
            String query = "DELETE FROM T_Platillos WHERE NumPlatillos = " + Request["ID"];
            fuction_trigger(query);
            string connection = ConfigurationManager.ConnectionStrings["CatalogoPlatillosConnectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = query;
            cmd.Connection = con;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Response.Redirect("ConsultarPlatillos.aspx");
        }
    }
}