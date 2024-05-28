using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace WebApplication9
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            con.Open();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd  = new SqlCommand("insert into tbl values ('" + TextBox1.Text + "','" + TextBox2.Text + "','"+TextBox3.Text+ "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + DropDownList1.Text + "','"+RadioButtonList1.Text+"')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            Label1.Text = "Appointment Booked successfully";
            GridView1.DataBind();
        }
    }
}