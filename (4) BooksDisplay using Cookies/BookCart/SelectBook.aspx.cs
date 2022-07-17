using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BookCart
{
    public partial class SelectBook : System.Web.UI.Page
    {
        Dictionary<String, String> books;
        protected void Page_Init(object sender, EventArgs e)
        {
            //instantiate the dictionary
            books = new Dictionary<string, string>();
            //add books
            books.Add("C++","Bjarne Stroustrup");
            books.Add("Java", "Ivor Horton");
            books.Add("C", "Dennis Ritchie");
            books.Add("Machine Learning", "Tom Mitchell");
            books.Add("Angels and Daemons", "Dan Brown");
            books.Add("The other side of midnight", "Sidney Sheldon");
            lstbooks.Items.Clear();
            foreach(String s in books.Keys)
            {
                lstbooks.Items.Add(s);
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnadd_Click(object sender, EventArgs e)
        {
            if(lstbooks.SelectedIndex >= 0)
            {
                //get the selected book
                String bn = lstbooks.SelectedValue;
                String bdesc = books[bn];
                //create a cookie
                HttpCookie c1 = new HttpCookie(bn, bdesc);
                //add cookie to response
                Response.Cookies.Add(c1);
            }
            else
            {
                lblmsg.Text = "Please select a book";
            }
        }
    }
}