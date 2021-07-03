using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;

namespace MyAutoCompleteTextBox201913709054_FarukAydogan
{
    public partial class Form2 : Form
    {
        // Border Radius section
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
     (
         int nLeftRect,     // x-coordinate of upper-left corner
         int nTopRect,      // y-coordinate of upper-left corner
         int nRightRect,    // x-coordinate of lower-right corner
         int nBottomRect,   // y-coordinate of lower-right corner
         int nWidthEllipse, // height of ellipse
         int nHeightEllipse // width of ellipse
     );
        // Border Radius section ended
        public Form2 ( )
        {
            InitializeComponent();

        }

        private void Form2_Load ( object sender, EventArgs e )
        {

        }
        public string[] isimler = System.IO.File.ReadAllLines(@"C:\MyAutoCompleteTextBox201913709054_FarukAydogan\MyAutoCompleteTextBox201913709054_FarukAydogan\img\isimler");


        // Email edit section


     

        private void textEdit1_KeyUp_1 ( object sender, KeyEventArgs e )
        {
            listBox1.Items.Clear();
            listBox1.Items.Add(textEdit1.Text + "@hotmail.com");
            listBox1.Items.Add(textEdit1.Text + "@gmail.com");
            listBox1.Items.Add(textEdit1.Text + "@yahoo.com");
            if(e.KeyCode == Keys.Down)
            {
                listBox1.Focus();
                listBox1.SelectedIndex=0;
            }

        }


        private void textEdit1_KeyPress_1 ( object sender, KeyPressEventArgs e )
        {
            if(e.KeyChar < 0 || e.KeyChar < 120)
            {
                if(textEdit1.Text != "")
                {
                    listBox1.Visible = true;
                    listBox1.Location = new Point(textEdit1.Location.X, textEdit1.Location.Y + 20);
                }
                else if(e.KeyChar== 64)
                {
                    listBox1.Focus();
                    listBox1.SelectedIndex=1;
                }
                else
                {
                    listBox1.Visible = false;
                }
                  
            }
        }

        private void listBox1_KeyDown_1 ( object sender, KeyEventArgs e )
        {
            if(e.KeyCode == Keys.Enter)
            {
                textEdit1.Text = listBox1.GetItemText(listBox1.SelectedItem);
                listBox1.Visible = false;
                textEdit2.Focus();
            }
          
        }


        private void listBox1_MouseDoubleClick_1 ( object sender, MouseEventArgs e )
        {
            textEdit1.Text = listBox1.GetItemText(listBox1.SelectedItem);
            listBox1.Visible = false;
            textEdit2.Focus();


        }

        // Email edit section ended



        // location edit section


        private void textEdit2_KeyDown_1 ( object sender, KeyEventArgs e )
        {
           

        }
        private void textEdit2_KeyUp ( object sender, KeyEventArgs e )
        {
            if(e.KeyCode == Keys.Down)
            {
                listBox2.Focus();
                listBox2.SelectedIndex=0;

            }
            else
            {
                listBox2.Items.Clear();
                string textedit = textEdit2.Text.ToLower();
                for(int i = 0; i < isimler.Length; i++)
                {
                    string isim = isimler[i].ToLower();
                    if(textedit == isim[0].ToString() || textedit == isim[0].ToString()+isim[1].ToString()|| textedit == isim[0].ToString()+isim[1].ToString()+isim[2].ToString())
                    {
                        listBox2.Items.Add(isimler[i]);
                    }
                }
            }
        }

        private void textEdit2_KeyPress_1 ( object sender, KeyPressEventArgs e )
        {
            if(e.KeyChar < 0 || e.KeyChar < 120)
            {
                if(textEdit2.Text != "")
                {
                    listBox2.Visible = true; listBox2.Location = new Point(textEdit2.Location.X, textEdit2.Location.Y + 20);
                }
                else
                {
                    listBox2.Visible = false;
                }
            }
        }
        // Email edit section ended


        private void listBox2_KeyDown_1 ( object sender, KeyEventArgs e )
        {
            if(e.KeyCode == Keys.Enter)
            {
                textEdit2.Text = listBox2.GetItemText(listBox2.SelectedItem);
                listBox2.Visible = false;
                simpleButton1.Focus();
            }
        }


        private void listBox2_MouseDoubleClick ( object sender, MouseEventArgs e )
        {
            textEdit2.Text = listBox2.GetItemText(listBox2.SelectedItem);
            listBox2.Visible = false;
            simpleButton1.Focus();

        }


        private void simpleButton1_Click_1 ( object sender, EventArgs e )
        {
            try
            {
                if(textEdit1.Text!=""||textEdit2.Text!="")
                {
                    MessageBox.Show($"Hoşgeldiniz Sayın {textEdit2.Text.ToString()} Epostanız : {textEdit1.Text.ToString()}");
                    this.Close();
                }
                else
                {
                    throw new Exception();
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Eposta ve isim boş girilemez");
            }
        }

        private void simpleButton2_DoubleClick ( object sender, EventArgs e )
        {
            System.Diagnostics.Process.Start("https://appstoreconnect.apple.com/login");
        }

        private void simpleButton3_MouseDoubleClick ( object sender, MouseEventArgs e )
        {
            System.Diagnostics.Process.Start("https://www.google.com/url?sa=t&rct=j&q=&esrc=s&source=web&cd=&cad=rja&uact=8&ved=2ahUKEwi9k7TK6avxAhWzgP0HHZYZCPQQjBAwAXoECAIQAQ&url=https%3A%2F%2Faccounts.google.com%2Fservicelogin%3Fhl%3Den&usg=AOvVaw0fOcUEEt3Fw_GQQ1mr5T6d");
        }
    }
}

