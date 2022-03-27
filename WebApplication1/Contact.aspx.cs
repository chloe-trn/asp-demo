using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Title = "On Page Load";
            }
            else 
            {
                Title = "Postback Data: " + TextBox1.Text;
            }
            
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}