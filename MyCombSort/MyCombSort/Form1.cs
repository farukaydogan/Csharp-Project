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

namespace MyCombSort
{
    public partial class Form1 : Form
    {
        public Form1 ( )
        {
            InitializeComponent();
          
        }
        SqlConnection conn = new SqlConnection("Data Source=TC;Initial Catalog=MyCombSort;Integrated Security=True");
        private void Read ( )
        {
            conn.Open();
            SqlCommand komut = new SqlCommand("Select *From Data", conn);
            SqlDataReader read = komut.ExecuteReader();
            while(read.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = read["veri"].ToString();
                CombSort cmb = new CombSort();
                cmb.Text=ekle.Text.ToString();
                Controls.Add(cmb);
            }
            conn.Close();
        }
        private void Form1_Load ( object sender, EventArgs e )
        {

        }
    }
}
