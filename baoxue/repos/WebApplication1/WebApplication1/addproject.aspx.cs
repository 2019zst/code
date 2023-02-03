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
    public partial class addproject : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text.Trim() == "" || TextBox3.Text.Trim() == "")
            {
                this.Response.Write("<script>alert('内容不为空')</script>");
            }

            if (TextBox1.Text.Trim() != "" && TextBox3.Text.Trim() != "")
            {
                string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
                MySqlConnection conn = new MySqlConnection(constr);
                conn.Open();

                string sql = "insert into sciproject (ProjectName,Projectdec,user_id) values('"+TextBox1.Text.Trim()+"','"+TextBox3.Text.Trim()+ "','" +Session["userid"]+"')";
                MySqlCommand comm = new MySqlCommand(sql, conn);
                comm.ExecuteNonQuery();
               
                string sql2 = "select *from sciproject where ProjectName='" + TextBox1.Text.Trim() + "'and Projectdec='" + TextBox3.Text.Trim() + "'and user_id='"+Session["userid"] + "'";
                MySqlCommand comm2 = new MySqlCommand(sql2, conn);
                MySqlDataReader reader = comm2.ExecuteReader();
                reader.Read();
                string sci_id = reader[0].ToString();
                reader.Close();
                string sql3 = "insert into project_declare (Project_id,user_id,State) values('"+ sci_id + "','" + Session["userid"] + "','未通过')";
                MySqlCommand comm3 = new MySqlCommand(sql3, conn);
                comm3.ExecuteNonQuery();
                this.Response.Write("<script>alert('申报成功')</script>");



            }

        }
    }
    
}