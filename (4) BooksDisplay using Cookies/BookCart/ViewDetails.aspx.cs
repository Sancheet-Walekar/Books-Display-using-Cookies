using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BookCart
{
    public partial class ViewDetails : System.Web.UI.Page
    {
        HttpCookieCollection cookies;
        protected void Page_Load(object sender, EventArgs e)
        {
            //fetch all cookies
            cookies = Request.Cookies;

            //display cookies in listbox
            if(cookies.Count > 0)
            {
                for(int i=0; i<cookies.Count; i++)
                {
                    ListBox1.Items.Add("Book: " + cookies[i].Name + "Desc: " + cookies[i].Value);
                }
            }
            else
            {
                ListBox1.Items.Add("No Books Selected");
            }
        }
    }
}