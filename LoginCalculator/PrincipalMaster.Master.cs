using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoginCalculator
{
    public partial class PrincipalMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session.Timeout = 5;
            if (Session["user"] == null)
            {
                Response.Redirect("/LoginMaster.aspx");
            }
            else
            {

            };
        }
    }
}