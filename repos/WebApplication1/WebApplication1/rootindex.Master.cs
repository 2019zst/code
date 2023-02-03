using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class main : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string Username = Session["Username"].ToString();
        }

        protected void Menu3_MenuItemClick(object sender, MenuEventArgs e)
        {
      
            

        }
    }
}