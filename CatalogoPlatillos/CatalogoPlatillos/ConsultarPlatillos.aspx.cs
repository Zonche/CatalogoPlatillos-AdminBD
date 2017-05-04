using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CatalogoPlatillos
{
    public partial class ConsultarPlatillos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuario"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            if (!Page.IsPostBack)
            {
                string connection = ConfigurationManager.ConnectionStrings["CatalogoPlatillosConnectionString"].ConnectionString;
                SqlConnection con = new SqlConnection(connection);
                SqlCommand cmd = new SqlCommand();
                SqlDataReader sqldr;
                cmd.CommandType = System.Data.CommandType.Text;
                string query = "SELECT DISTINCT Categoria FROM T_Platillos";
                cmd.CommandText = query;
                cmd.Connection = con;
                con.Open();
                sqldr = cmd.ExecuteReader();
                while (sqldr.Read())
                {
                    ddlCategoria.Items.Add(sqldr["Categoria"].ToString());
                }
                con.Close();
            }           
        }

        protected void ddlCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            String query = "SELECT *, '<a href=''ModificarPlatillo.aspx?ID=' + Convert(varchar,[NumPlatillos]) + '''>Modificar</a>' As Liga FROM [T_Platillos] WHERE " +
                "Categoria = '" + ddlCategoria.SelectedValue + "'";
            DataSet ds = GetData(query);
            if (ds.Tables.Count > 0)
            {
                gvPlatillos.DataSource = ds;
                gvPlatillos.DataBind();
            }
        }
        DataSet GetData(String query)
        {
            String connection = ConfigurationManager.ConnectionStrings["CatalogoPlatillosConnectionString"].ConnectionString;
            DataSet ds = new DataSet();
            try
            {
                SqlConnection con = new SqlConnection(connection);
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                adapter.Fill(ds);
            }
            catch
            {
              
                throw;
            }
            return ds;
        }
        }
    }
