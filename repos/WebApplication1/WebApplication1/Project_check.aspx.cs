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
    public partial class Project_check : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
                string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            MySqlConnection conn = new MySqlConnection(constr);
            conn.Open();

            string sql = "select  name,Age,Department,ProjectName,projectdec ,State,project_check.Project_id,user.user_id from user,sciproject,project_check where project_check.user_id=user.user_id and  sciproject.Project_id=project_check.Project_id;";
            MySqlCommand comm = new MySqlCommand(sql, conn);
            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(comm);
            da.Fill(ds);
            GridView3.DataSource = ds.Tables[0];
            GridView3.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            MySqlConnection conn = new MySqlConnection(constr);
            conn.Open();

            string sql = "select  name,Age,Department,ProjectName,projectdec ,State,project_check.Project_id,user.user_id from user,sciproject,project_check where project_check.user_id=user.user_id and  sciproject.Project_id=project_check.Project_id and ProjectName='" + TextBox1.Text.Trim() + "'";
            MySqlCommand comm = new MySqlCommand(sql, conn);
            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(comm);
            da.Fill(ds);
            GridView3.DataSource = ds.Tables[0];
            GridView3.DataBind();
        }

        protected void GridView3_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string pro_id = GridView3.Rows[e.RowIndex].Cells[6].Text;
            string user_id = GridView3.Rows[e.RowIndex].Cells[7].Text;

            string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            MySqlConnection conn = new MySqlConnection(constr);
            conn.Open();

            string sql = "update project_check set State='已验收' where Project_id='" + pro_id + "'";
            MySqlCommand comm = new MySqlCommand(sql, conn);

            ////string sql2 = "insert into project_approval values('" + pro_id + "','" + user_id + "','未批准') ";
            ////MySqlCommand comm2 = new MySqlCommand(sql2, conn);
            //comm2.ExecuteNonQuery();

            int row = comm.ExecuteNonQuery();
            if (row > 0)
            {
                this.Response.Write("<script>alert('验收成功')</script>");

            }
            Response.Redirect("Project_check.aspx");
      

        }
    }
}