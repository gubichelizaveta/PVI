using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab_4_WebForm
{
    public partial class Concat : Page
    {
        private SimplexClient client;

        protected void Page_Load(object sender, EventArgs e)
        {
            client = new SimplexClient();
        }

        protected void Concat_Click(object sender, EventArgs e)
        {
            string s = first.Text.ToString();
            double d;
            if (Double.TryParse(second.Text.ToString(), out d))
            {
                result.Text = client.Concat(s,d);
            }
            else
            {
                result.Text = "Error!";
            }
        }
    }
}