using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data;
using System.Configuration;

namespace WebApplication1
{
    public partial class update : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string id = Request.QueryString["id"].ToString();
             

                string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
                MySqlConnection conn = new MySqlConnection(constr);
                conn.Open();

                string sql = "select * from user where User_id ='"+id+"'";
                MySqlCommand comm = new MySqlCommand(sql, conn);

                MySqlDataReader reader = comm.ExecuteReader();
                reader.Read();

                TextBox1.Text = reader[1].ToString();
                TextBox2.Text = reader[3].ToString();
                TextBox3.Text = reader[4].ToString();
                TextBox4.Text = reader[5].ToString();
                TextBox5.Text = reader[6].ToString();
                TextBox6.Text = reader[7].ToString();
                TextBox7.Text = reader[8].ToString();


                reader.Close();


            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string id = Request.QueryString["id"].ToString();
            string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            MySqlConnection conn = new MySqlConnection(constr);
            conn.Open();
            try
            {
                string sql = "update user set name='" + TextBox1.Text.Trim() + "',Account='" + TextBox2.Text.Trim() + "',Password= '" + TextBox3.Text.Trim() + "',Age='" + TextBox4.Text.Trim() + "',Department='" + TextBox5.Text.Trim() + "',Title='" + TextBox6.Text.Trim() + "',number='" + TextBox7.Text.Trim() + "'where User_id='" + id + "'";
                MySqlCommand comm = new MySqlCommand(sql, conn);
                int row = comm.ExecuteNonQuery();
                if (row > 0)
                {
                    this.Response.Write("<script>alert('修改成功')</script>");
                }
            }catch(Exception ex)
            {
                this.Response.Write("<script>alert('信息框不为空')</script>");
            }
        }
    }
}