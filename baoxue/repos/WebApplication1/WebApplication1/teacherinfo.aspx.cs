using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using MySql.Data.MySqlClient;


namespace WebApplication1
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          

            string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            MySqlConnection conn = new MySqlConnection(constr);
            conn.Open();

            string sql = "select * from user where Identity ='教师' ";
            MySqlCommand comm = new MySqlCommand(sql, conn);
            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(comm);
            da.Fill(ds);
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e )
        {
           
            Response.Write("ww");

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            MySqlConnection conn = new MySqlConnection(constr);
            conn.Open();
            /*Identity,Account,Password,Age,Department,Title,number*/
            string sql = "select * from user where CONCAT(name,number,Department)  ='" + TextBox1.Text.Trim()+ "' and Identity ='教师'";
            MySqlCommand comm = new MySqlCommand(sql, conn);
            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(comm);
            da.Fill(ds);
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                string id = GridView1.DataKeys[e.RowIndex].Value.ToString();
          
            string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            MySqlConnection conn = new MySqlConnection(constr);
            conn.Open();
            /*Identity,Account,Password,Age,Department,Title,number*/
            string sql = "delete  from user where User_id='"+id+"'";
            MySqlCommand comm = new MySqlCommand(sql, conn);
            int row=comm.ExecuteNonQuery();
            if (row > 0)
            {
                this.Response.Write("<script>alert('删除成功')</script>");
            }
            }
            catch (Exception ex)
            {
               
            };
            Response.Redirect(Request.Url.ToString());
        }

        

        protected void GridView1_RowUpdated(object sender, GridViewUpdatedEventArgs e)
        {

        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            string id = GridView1.Rows[e.NewEditIndex].Cells[0].Text;
            Response.Redirect("update.aspx?id=" + id);

          
        }

        protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
        {

        }
    }
}