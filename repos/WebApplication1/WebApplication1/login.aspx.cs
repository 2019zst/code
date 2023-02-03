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
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {

        }

     

        protected void Button1_Click1(object sender, EventArgs e)
        {
            if(TextBox1.Text.Trim()==""||TextBox2.Text.Trim()=="")
            {
                this.Response.Write("<script>alert('密码或账号不为空')</script>");
            }

            if (TextBox1.Text.Trim() != "" && TextBox2.Text.Trim() != "")
            {
                string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
                MySqlConnection conn = new MySqlConnection(constr);
                conn.Open();
         
                string sql = "select *from user where Account='" + TextBox1.Text.Trim() + "' and Password='" + TextBox2.Text.Trim() + "'";
                MySqlCommand comm = new MySqlCommand(sql, conn);
                MySqlDataReader reader = comm.ExecuteReader();
               
                reader.Read();

                try
                {
                    if (reader[2].ToString() == "管理员")
                    {
                        Session["username"] = reader[1].ToString();
                        Session["userid"]=reader[0].ToString();
                        this.Response.Redirect("rootindex.aspx");

                    }
                    if (reader[2].ToString() == "教师")
                    {
                        Session["username"] = reader[1].ToString();
                        Session["userid"] = reader[0].ToString();
                        this.Response.Redirect("teacherindex.aspx");

                    }

                }
                catch(Exception ex)
                {
                    this.Response.Write("<script>alert('用户或密码错误')</script>");
                };
              



            }

        }
    }
}