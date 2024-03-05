using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab_4_WebForm
{
    public partial class Sum : Page
    {
        private SimplexClient client;
        private A A;

        protected void Page_Load(object sender, EventArgs e)
        {
            client = new SimplexClient();
        }

        protected void Sum_Click(object sender, EventArgs e)
        {
            try
            {
                var a1 = new A();
                a1.s = A1_s.Text;
                a1.k = int.Parse(A1_k.Text);
                a1.f = float.Parse(A1_f.Text);

                var a2 = new A();
                a2.s = A2_s.Text;
                a2.k = int.Parse(A2_k.Text);
                a2.f = float.Parse(A2_f.Text);

                var a = client.Sum(a1, a2);

                result_s.Text = a.s;
                result_k.Text = a.k.ToString();
                result_f.Text = a.f.ToString();
            }
            catch (Exception)
            {
                result_s.Text = "Error!";
                result_k.Text = "Error!";
                result_f.Text = "Error!";
            }
        }
    }
}