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
    public partial class adduser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            MySqlConnection conn = new MySqlConnection(constr);
            conn.Open();
            /*Identity,Account,Password,Age,Department,Title,number*/
            string sql = "insert into user (name,Account,Password, Age,Department,Title,number)values('" + TextBox1.Text.Trim()+ "','" + TextBox2.Text.Trim() + "','" + TextBox3.Text.Trim() + "','" + TextBox4.Text.Trim() + "','" + TextBox5.Text.Trim() + "','" + TextBox6.Text.Trim() + "','" + TextBox7.Text.Trim() + "')";
            MySqlCommand comm = new MySqlCommand(sql, conn);
            try
            {
                comm.ExecuteNonQuery();
                this.Response.Write("<script>alert('添加成功')</script>");
            }
            catch (Exception ex)
            {
               this.Response.Write("<script>alert('输入框不能为空')</script>");
            };
            //MySqlDataReader reader = comm.ExecuteReader();

            //reader.Read();

            //try
            //{
            //    if (reader[2].ToString() == "管理员")
            //    {
            //        Session["username"] = reader[1].ToString();
            //        Session["userid"] = reader[0].ToString();
            //        this.Response.Redirect("rootindex.aspx");

            //    }
            //    if (reader[2].ToString() == "教师")
            //    {
            //        Session["username"] = reader[1].ToString();
            //        Session["userid"] = reader[0].ToString();
            //        this.Response.Redirect("teacherindex.aspx");

            //    }

            //}
            //catch (Exception ex)
            //{
            //    this.Response.Write("<script>alert('用户或密码错误')</script>");
            //};
        }
        }
}