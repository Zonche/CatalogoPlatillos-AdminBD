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
    public partial class ListaPedidos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuario"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            if (!Page.IsPostBack)
            {
                string query = "SELECT IDPEDIDO,CLIENTE,DIRECCION,PLATILLO,CANTIDAD,PRECIO,FECHA,DESCRIPCION FROM T_PEDIDOS";
                string connection = ConfigurationManager.ConnectionStrings["CatalogoPlatillosConnectionString"].ConnectionString;
                SqlConnection con = new SqlConnection(connection);
                SqlCommand cmd = new SqlCommand(query);
                SqlDataAdapter sda = new SqlDataAdapter();
                DataSet ds = new DataSet();
                //Creando la funcion para leer el query
                //Empieza el proceso para la lectura y llenado del GridView
                cmd.Connection = con;
                sda.SelectCommand = cmd;
                sda.Fill(ds,"T_PEDIDOS");
                gvPedidos.DataSource = ds.Tables["T_PEDIDOS"];
                gvPedidos.DataBind();
                con.Open();
                con.Close();
            }      
        }

        protected void ddlFechas_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}