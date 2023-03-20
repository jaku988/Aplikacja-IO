using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace wko
{
    public partial class log : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into tbllogin values(@name,@Pass,@city,@gender,@mail)", con);
                cmd.Parameters.AddWithValue("name", TextBox1.Text);
                cmd.Parameters.AddWithValue("Pass", TextBox2.Text);
                cmd.Parameters.AddWithValue("city", DropDownList1.SelectedValue);
                cmd.Parameters.AddWithValue("genders", RadioButtonList1.SelectedValue);
                cmd.Parameters.AddWithValue("mail", TextBox4.Text);
                cmd.ExecuteNonQuery();


                TextBox1.Text = default;
                TextBox2.Text = default;
                DropDownList1.SelectedValue = default;
                RadioButtonList1.SelectedValue = default;
                TextBox4.Text = default;
                TextBox1.Focus();
            }
        }
    }
}