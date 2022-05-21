using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FathAlrahman
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source = .\SQLEXPRESS; Initial Catalog = RealApplication; Integrated Security = True");
        public Form1()
        {
            InitializeComponent();
        }

        private void txt_Parcode_TextChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string Query = "Select * From TBL_Product Where Parcode = N'"+txt_Parcode.Text.Trim()+"' ";
                SqlCommand cmd = new SqlCommand(Query, con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Product_Name.Text = dr[0].ToString();
                    Price.Text = dr[1].ToString();
                    QTY.Text = dr[2].ToString();
                }
                dr.Close();
                con.Close();
            }
            catch { }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AutoCompleteTextBox();
        }
        public void AutoCompleteTextBox()
        {
            try
            {
                con.Open();
                AutoCompleteStringCollection col = new AutoCompleteStringCollection();
                string Query = "Select Parcode from TBL_Product Where Parcode = N'" + txt_Parcode.Text.Trim()+"' ";
                SqlCommand cmd  = new SqlCommand(Query, con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    col.Add(dr.GetString(1));
                }
                dr.Close();
                txt_Parcode.AutoCompleteCustomSource = col;
                con.Close();
            }
            catch { }
        }

    }
}
