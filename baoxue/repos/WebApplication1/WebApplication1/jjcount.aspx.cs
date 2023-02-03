﻿using System;
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
    public partial class jjcount : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            MySqlConnection conn = new MySqlConnection(constr);
            conn.Open();

            string sql = "select  name,Age,Department,ProjectName,projectdec ,State,project_declare.Project_id,user.user_id from user,sciproject,project_declare where project_declare.user_id=user.user_id and  sciproject.Project_id=project_declare.Project_id and  Department='经济系' ";
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
    }
}