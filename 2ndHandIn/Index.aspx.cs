using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _2ndHandIn
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void UpdateCustomerListView()
        {
            ListBoxCustomers.Items.Clear();
            foreach (Customer c in Customers.customersList)
            {
                ListBoxCustomers.Items.Add(c.ToString());
            }
        }

        protected void ButtonCreate_Click(object sender, EventArgs e)
        {
            Customer c = new Customer(TextBoxName.Text, int.Parse(TextBoxAge.Text), int.Parse(TextBoxZipcode.Text), TextBoxPassword.Text);
            Customers.customersList.Add(c);
        }

        protected void ButtonJylland_Click(object sender, EventArgs e)
        {
            ListBoxCustomers.Items.Clear();

            foreach (Customer c in Customers.customersList)
            {
                if (Enumerable.Range(6000, 4000).Contains(c.Zipcode))
                {
                    ListBoxCustomers.Items.Add(c.ToString());
                }
            }
        }

        protected void ButtonFyn_Click(object sender, EventArgs e)
        {
            ListBoxCustomers.Items.Clear();
            foreach (Customer c in Customers.customersList)
            {
                if (Enumerable.Range(5000, 1000).Contains(c.Zipcode))
                {
                    ListBoxCustomers.Items.Add(c.ToString());
                }
            }
        }

        protected void ButtonSjælland_Click(object sender, EventArgs e)
        {
            ListBoxCustomers.Items.Clear();
            foreach (Customer c in Customers.customersList)
            {
                if (Enumerable.Range(1000, 4000).Contains(c.Zipcode))
                {
                    ListBoxCustomers.Items.Add(c.ToString());
                }
            }
        }

        protected void ButtonAll_Click(object sender, EventArgs e)
        {
            UpdateCustomerListView();
        }
    }
}