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
                SqlCommand cmd = new SqlCommand("insert into tbllogin values(@imie,@haslo,@miasto,@plec,@mail)", con);
                cmd.Parameters.AddWithValue("Imie", TextBox1.Text);
                cmd.Parameters.AddWithValue("Haslo", TextBox2.Text);
                cmd.Parameters.AddWithValue("Miasto", TextBox5.Text);
                cmd.Parameters.AddWithValue("plec", RadioButtonList1.SelectedValue);
                cmd.Parameters.AddWithValue("mail", TextBox4.Text);
                cmd.ExecuteNonQuery();


                TextBox1.Text = default;
                TextBox2.Text = default;
                TextBox5.Text = default;
                RadioButtonList1.SelectedValue = default;
                TextBox4.Text = default;
                TextBox1.Focus();
            }
        }
    }
}