using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoginCalculator
{
    public partial class AdminIndex : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        protected void nlkSeleccionar_Click(object sender, EventArgs e)
        {
            Session["user"] = null;
            Response.Redirect("/LoginMaster.aspx");
        }
    }
}