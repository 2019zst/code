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
    public partial class Project_approval : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            MySqlConnection conn = new MySqlConnection(constr);
            conn.Open();

            string sql = "select  name,Age,Department,ProjectName,projectdec ,State,project_approval.Project_id,user.user_id from user,sciproject,project_approval where project_approval.user_id=user.user_id and  sciproject.Project_id=project_approval.Project_id";
            MySqlCommand comm = new MySqlCommand(sql, conn);
            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(comm);
            da.Fill(ds);
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            MySqlConnection conn = new MySqlConnection(constr);
            conn.Open();

            string sql = "select  name,Age,Department,ProjectName,projectdec ,State,project_approval.Project_id,user.user_id from user,sciproject,project_approval where project_approval.user_id=user.user_id and  sciproject.Project_id=project_approval.Project_id and ProjectName='" + TextBox1.Text.Trim() + "'";
            MySqlCommand comm = new MySqlCommand(sql, conn);
            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(comm);
            da.Fill(ds);
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            string pro_id = GridView1.Rows[e.NewEditIndex].Cells[6].Text;
            string user_id = GridView1.Rows[e.NewEditIndex].Cells[7].Text;

            string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            MySqlConnection conn = new MySqlConnection(constr);
            conn.Open();

            string sql = "update project_approval set State='批准通过' where Project_id='" + pro_id + "'";
            MySqlCommand comm = new MySqlCommand(sql, conn);

            string sql2 = "insert into project_check values('" + pro_id + "','" + user_id + "','未验证') ";
            MySqlCommand comm2 = new MySqlCommand(sql2, conn);
            comm2.ExecuteNonQuery();

            int row = comm.ExecuteNonQuery();
            if (row > 0)
            {
                this.Response.Write("<script>alert('通过成功')</script>");

            }
            Response.Redirect("Project_approval.aspx");

        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {

        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string pro_id = GridView1.Rows[e.RowIndex].Cells[6].Text;
            string user_id = GridView1.Rows[e.RowIndex].Cells[7].Text;

            string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            MySqlConnection conn = new MySqlConnection(constr);
            conn.Open();

            string sql = "update project_approval set State='不通过' where Project_id='" + pro_id + "'";
            MySqlCommand comm = new MySqlCommand(sql, conn);

            //string sql2 = "insert into project_approval values('" + pro_id + "','" + user_id + "','未验证') ";
            //MySqlCommand comm2 = new MySqlCommand(sql2, conn);
            //comm2.ExecuteNonQuery();

            int row = comm.ExecuteNonQuery();
            if (row > 0)
            {
                this.Response.Write("<script>alert('不通过成功')</script>");

            }
            Response.Redirect("Project_approval.aspx");
        }
    }
}