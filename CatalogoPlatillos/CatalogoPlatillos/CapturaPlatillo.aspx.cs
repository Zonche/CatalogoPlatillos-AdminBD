using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;

namespace CatalogoPlatillos
{
    public partial class CapturaPlatillo : System.Web.UI.Page
    {
        string Query = "";
        //funciones
        private void fuction_trigger(string query)
        {
            string connection = ConfigurationManager.ConnectionStrings["CatalogoPlatillosConnectionString"].ConnectionString;
            SqlConnection Con = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = String.Format("Update T_Usuarios set Querys = '{0}',Host = Host_Name() where Usuario =\'{1}\'",
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
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            lbl_mensaje.Text = "";
            try
            {
                if (TxtNombrePlatillo.Text != "")
                {
                    if (TxtPrecio.Text != "")
                    {
                        int validar;
                        if (int.TryParse(TxtPrecio.Text, out validar))
                        {
                            Query = String.Format("INSERT INTO T_Platillos(Nombre_Platillo, Categoria, Precio, Descripcion) VALUES('{0}','{1}','{2}','{3}');",
                            TxtNombrePlatillo.Text,
                            ddlcategoria.SelectedValue,
                            TxtPrecio.Text,
                            TxtDescripcion.Text);

                            fuction_trigger(Query);
                            string connection = ConfigurationManager.ConnectionStrings["CatalogoPlatillosConnectionString"].ConnectionString;
                            SqlConnection Con = new SqlConnection(connection);
                            SqlCommand cmd = new SqlCommand();
                            cmd.CommandType = System.Data.CommandType.Text;
                            cmd.CommandText = Query;
                            cmd.Connection = Con;
                            Con.Open();
                            cmd.ExecuteNonQuery();
                            Con.Close();
                            TxtNombrePlatillo.Text = "";
                            TxtPrecio.Text = "";
                            TxtDescripcion.Text = "";
                            ddlcategoria.Text = "Desayuno";
                            lbl_mensaje.Text = "Nuevo Platilo Guardado";

                        }
                        else
                        {
                            lbl_mensaje.Text = "Escribe el Precio correcto";
                        }
                    }
                    else
                    {
                        lbl_mensaje.Text = "Escribe correctamente el año";
                    }
                }
                else
                {
                    lbl_mensaje.Text = "Teclea Nombre del platillo";
                }

            }
            catch (Exception ex)
            {
                lbl_mensaje.Text = ex.Message;
            }
            
        }
    }
}