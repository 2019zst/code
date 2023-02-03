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
    public partial class Project_declare : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            MySqlConnection conn = new MySqlConnection(constr);
            conn.Open();

            string sql = "select  name,Age,Department,ProjectName,projectdec ,State,project_declare.Project_id,user.user_id from user,sciproject,project_declare where project_declare.user_id=user.user_id and  sciproject.Project_id=project_declare.Project_id ";
            MySqlCommand comm = new MySqlCommand(sql, conn);
            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(comm);
            da.Fill(ds);
            GridView2.DataSource = ds.Tables[0];
            GridView2.DataBind();

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            MySqlConnection conn = new MySqlConnection(constr);
            conn.Open();

            string sql = "select  name,Age,Department,ProjectName,projectdec ,State,project_declare.Project_id,user.user_id from user,sciproject,project_declare where project_declare.user_id=user.user_id and  sciproject.Project_id=project_declare.Project_id and ProjectName='"+ TextBox2.Text.Trim() +"'";
            MySqlCommand comm = new MySqlCommand(sql, conn);
            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(comm);
            da.Fill(ds);
            GridView2.DataSource = ds.Tables[0];
            GridView2.DataBind();
        }

        protected void GridView2_RowEditing(object sender, GridViewEditEventArgs e)
        {
            string pro_id = GridView2.Rows[e.NewEditIndex].Cells[6].Text;
            string user_id = GridView2.Rows[e.NewEditIndex].Cells[7].Text;
       
            string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            MySqlConnection conn = new MySqlConnection(constr);
            conn.Open();

            string sql = "update project_declare set State='申报通过' where Project_id='"  +pro_id+ "'";
            MySqlCommand comm = new MySqlCommand(sql, conn);

            string sql2 = "insert into project_approval values('" + pro_id + "','" + user_id + "','未批准') ";
            MySqlCommand comm2 = new MySqlCommand(sql2, conn);
            comm2.ExecuteNonQuery();

            int row=comm.ExecuteNonQuery();
            if (row > 0)
            {
                this.Response.Write("<script>alert('通过成功')</script>");
       
            }

            Response.Redirect("Project_declare.aspx");
        }

        protected void GridView2_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {

            //string pro_id = GridView2.Rows[e.NW].Cells[6].Text;
            //string user_id = GridView2.Rows[e.RowIndex].Cells[7].Text;
            //Response.Write(pro_id + user_id);
            //string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            //MySqlConnection conn = new MySqlConnection(constr);
            //conn.Open();

            //string sql = "update project_declare set State='申报通过' where Project_id='" + pro_id + "'";
            //MySqlCommand comm = new MySqlCommand(sql, conn);

            //string sql2 = "insert into project_approval values('" + pro_id + "','" + user_id + "','未批准') ";
            //MySqlCommand comm2 = new MySqlCommand(sql2, conn);
            //comm2.ExecuteNonQuery();

            //int row = comm.ExecuteNonQuery();
            //if (row > 0)
            //{
            //    this.Response.Write("<script>alert('通过成功')</script>");

            //}
        }

        protected void GridView2_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string pro_id = GridView2.Rows[e.RowIndex].Cells[6].Text;
            string user_id = GridView2.Rows[e.RowIndex].Cells[7].Text;

            string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            MySqlConnection conn = new MySqlConnection(constr);
            conn.Open();

            string sql = "update project_declare set State='不通过' where Project_id='" + pro_id + "'";
            MySqlCommand comm = new MySqlCommand(sql, conn);

            ////string sql2 = "insert into project_approval values('" + pro_id + "','" + user_id + "','未批准') ";
            ////MySqlCommand comm2 = new MySqlCommand(sql2, conn);
            //comm2.ExecuteNonQuery();

            int row = comm.ExecuteNonQuery();
            if (row > 0)
            {
                this.Response.Write("<script>alert('不通过成功')</script>");

            }
            Response.Redirect("Project_declare.aspx");
        }
    }
}