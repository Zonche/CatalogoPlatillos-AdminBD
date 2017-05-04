using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace CatalogoPlatillos
{
    public partial class CapturaPedidos : System.Web.UI.Page
    {
        String Query;
        private void fuction_trigger(string query)
        {
            string connection = ConfigurationManager.ConnectionStrings["CatalogoPlatillosConnectionString"].ConnectionString;
            SqlConnection Con = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand();
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
            if (Session["usuario"]==null)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                string Query = "SELECT DISTINCT Nombre_Platillo FROM T_Platillos";
                string connection = ConfigurationManager.ConnectionStrings["CatalogoPlatillosConnectionString"].ConnectionString;
                SqlConnection con = new SqlConnection(connection);
                SqlCommand cmd = new SqlCommand();
                SqlDataReader sqlr;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = Query;
                cmd.Connection = con;
                con.Open();
                sqlr = cmd.ExecuteReader();
                while (sqlr.Read())
                {
                    ddlPlatillo.Items.Add(sqlr["Nombre_Platillo"].ToString());
                }
                con.Close();
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            Query = String.Format("INSERT INTO T_PEDIDOS(CLIENTE, DIRECCION,PLATILLO, CANTIDAD,PRECIO,FECHA,DESCRIPCION) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}')",
            TxtNombreCliente.Text,
            txtDireccion.Text,
            ddlPlatillo.SelectedValue,
            Convert.ToInt32(txtCantidad.Text),
            Convert.ToInt32(TxtPrecio.Text),
            cld_date.SelectedDate.ToShortDateString(),
            TxtDescripcion.Text);

            fuction_trigger(Query);
            string connection = ConfigurationManager.ConnectionStrings["CatalogoPlatillosConnectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = Query;
            cmd.Connection=con;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            TxtNombreCliente.Text = "";
            txtDireccion.Text = "";
            ddlPlatillo.SelectedIndex = -1;
            TxtDescripcion.Text = "";
            lbl_mensaje.Text = "Nuevo Pedido Guardado";
        }

        protected void ddlPlatillo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        protected void ddlcategoria_Load(object sender, EventArgs e)
        {
            
        }

        protected void ddlPlatillo_Load(object sender, EventArgs e)
        {

        }

        protected void ddlcategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        
    }
}