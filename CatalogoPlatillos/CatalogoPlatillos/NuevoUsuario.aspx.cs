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
    public partial class NuevoUsuario : System.Web.UI.Page
    {
        string U;
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
           
            if (txtNuevoUsuario.Text != "")
            {
                if (txtNuevoPassword.Text != "")
                {
                    if (txtNombre.Text != "")
                    {
                        string connection = ConfigurationManager.ConnectionStrings["CatalogoPlatillosConnectionString"].ConnectionString;
                        SqlConnection con = new SqlConnection(connection);
                        SqlCommand cmd = new SqlCommand();
                        SqlDataReader sqldr;
                        cmd.CommandType = System.Data.CommandType.Text;

                        String query = "SELECT * from T_usuarios where usuario ='" + txtNuevoUsuario.Text + "'";
                        cmd.CommandText = query;
                        cmd.Connection = con;
                        con.Open();
                        sqldr = cmd.ExecuteReader();
                        while (sqldr.Read())
                        {
                            U = sqldr["Usuario"].ToString();

                        }
                        con.Close();
                    }
                    else
                    {
                        lbl_mensaje.Text = "Escribe un nombre";
                    }
                }
                else
                {
                    lbl_mensaje.Text = "Escribe correctamente la contraseña";
                }
            }
            else
            {
                lbl_mensaje.Text = "Escribe correctamente el usuario";
            }

            // aqui 
            lbl_mensaje.Text = "";

            if (U != txtNuevoUsuario.Text )
            {
                try
                {
                    if (txtNuevoUsuario.Text != "")
                    {
                        if (txtNuevoPassword.Text != "")
                        {
                            if (txtNombre.Text != "")
                            {
                                string connection = ConfigurationManager.ConnectionStrings["CatalogoPlatillosConnectionString"].ConnectionString;
                            SqlConnection Con = new SqlConnection(connection);
                            SqlCommand cmd = new SqlCommand();
                            cmd.CommandType = System.Data.CommandType.Text;
                            cmd.CommandText = String.Format("INSERT INTO T_Usuarios(Usuario, Password,Nombre) VALUES({0}, {1},{2});",
                                txtNuevoUsuario.Text,
                                txtNuevoPassword.Text,
                                txtNombre.Text);

                            cmd.Connection = Con;
                            Con.Open();
                            cmd.ExecuteNonQuery();
                            Con.Close();
                            txtNuevoUsuario.Text = "";
                            txtNuevoPassword.Text = "";
                            txtNombre.Text = "";
                            lbl_mensaje.Text = "Usuario Registrado";
                            }
                            else
                            {
                                lbl_mensaje.Text = "Escribe un nombre";
                            }
                        }
                        else
                        {
                            lbl_mensaje.Text = "Escribe correctamente la contraseña";
                        }
                    }
                    else
                    {
                        lbl_mensaje.Text = "Escribe correctamente el usuario";
                    }

                }
                catch (Exception ex)
                {
                    lbl_mensaje.Text = ex.Message;
                }
            }
            else 
            {
                lbl_mensaje.Text = "El usuario ya existe";
            }

        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("LogIn.aspx");
        }
    }
}