﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCombSort
{
    public partial class CombSort : Control
    {
        public CombSort ( )
        {
            this.Size= new Size(150, 20);
            InitializeComponent();
        }

        //isimler adında autocomplete özelliğindeki isimleri yazıyoruz
        public string[] isimler = System.IO.File.ReadAllLines(@"C:\Users\faruk\source\repos\MyAutoCompleteTextBox201913709054_FarukAydogan\img\isimler");
        protected static int EDGE_PENDING = 4; //Iconun sol köşeye olan uzaklığı
        //Kullanacağımız değişkenler tanımlıyoruz
        protected ButtonState buttonState; //MyAutoCompleteTextBox durumunu tutacak
        protected Icon buttonIcon; // MyAutoCompleteTextBox üzerindeki icon
        protected int iconDrawWidth; //iconun yüksekligi
        protected bool mousePressed; // MyAutoCompleteTextBox basılı olup olmadığını belirlemek için
        ListBox lstBox = new ListBox(); //lstbox adında listbox tanımlıyoruz
        public int sayac = 0; // sayac değişkenini oluşturuyoruz çünkü ilk kez kullanılacağında texti boş bir string yapıp gerekli işlemleri yapıyoruz
        //Kullanıcıyı bilgilendirmek için nitelikler tanımlıyoruz.

        //Properties penceresinde Icon özelliği için kullanıcıya bilgi veriyoruz
        [System.ComponentModel.Description("Seçeceğiniz icon MyAutoCompleteTextBox üzerinde görünecektir"),
        //Icon özelliğinin Properties penceresinde hangi kategoride yer alacağını belirliyoruz
        System.ComponentModel.Category("AutoCompleteTextBox"),
        //Icon özelliğine varsayılan değeri veriyoruz
        System.ComponentModel.DefaultValue(null)]

        //Kullanıcının button için icon belirlemesi için Icon isimli bir özellik tanımlıyoruz
        
        //varsayılan yapılandırıcı
        //kontrolümüz için varsayılan değerleri veriyoruz  
      
            /// <summary>
            /// degeri 1 e eşitler
            /// </summary>
        
        protected override void OnMouseUp ( MouseEventArgs e )
        {
            if(mousePressed && (e.Button == MouseButtons.Left))
            {
                Capture = false;
                mousePressed = false;
                buttonState = ButtonState.Normal;
                Invalidate();
                Update();
            }
            else
            {
                base.OnMouseUp(e);
            }
        }

        //Kontrole paint mesajı geldiği zaman buttonun tekrar boyanmasını ve çizilmesini sağlamak için
        protected override void OnPaint ( PaintEventArgs e )
        {
            Draw(e.Graphics); //bu fonksiyon ile button için gerekli tüm çizim ve boyama işlemlerini yapacağız
            base.OnPaint(e);
        }
        protected override void OnKeyUp ( KeyEventArgs e )
        {
            if(e.KeyCode == Keys.Down)
            {
                lstBox.Focus();
                if(lstBox.Items.Count>=1)
                {
                    lstBox.SelectedIndex=0;
                }
            }
            else
            {
                lstBox.Items.Clear();
                string textedit = Text.ToLower();
                for(int i = 0; i < isimler.Length; i++)
                {
                    string isim = isimler[i].ToLower();
                    if(textedit == isim[0].ToString() || textedit == isim[0].ToString()+isim[1].ToString()|| textedit == isim[0].ToString()+isim[1].ToString()+isim[2].ToString())
                    {
                        lstBox.Items.Add(isimler[i]);
                    }
                }
            }
        }
        protected override void OnKeyPress ( KeyPressEventArgs e )
        {
            if(sayac==0)
            {
                Size = new Size(Width, Height*5);
                lstBox.Size =new Size(this.Width, Height);
                lstBox.Location=new Point(0, this.Height/3);
                lstBox.BackColor=Color.White;
                Controls.Add(lstBox);
                sayac++;
            }
        }
        /// <summary>
        /// tuşa basıldığında eğer sayac ilk kez kullanılıyorsa texti sıfırlar eğer tuş delete yani back tuşu ise stringin sonundaki elemanı siliyor
        /// </summary>
        /// <param name="e"></param>

        protected override void OnKeyDown ( KeyEventArgs e )
        {
            if(sayac==0)
            {
                Text="";
            }
            if(e.KeyCode.ToString()=="Back")
            {
                if(Text.Length>=1)
                {
                    Text= Text.Remove(Text.Length-1, 1);
                }
            }
            else
            {
                Text+= e.KeyCode.ToString();
            }
            Invalidate();
            Update();

        }
        /// <summary>
        ///   parametre olarak kontrolümüzün Graphics nesnesini veriyoruz ve control sınıfndaki draw methodunu virtual ile kullanıyoruz
        /// </summary>
        protected virtual void Draw ( Graphics g )
        {
            DrawButton(g);
            
            DrawText(g);
            if(base.Focused)
                DrawFocusClues(g);

        }

        /// <summary>
        /// Buttonumuzu çiziyoruz drawbutton methodu ile
        /// </summary>
        /// <param name="g"></param>
        protected virtual void DrawButton ( Graphics g )
        {

            Rectangle rcButton = new Rectangle(0, 0, this.Width, this.Height); //button çizimi için alan belirliyoruz
            ControlPaint.DrawButton(g, rcButton, buttonState);//control paint ile draw button özelliğini kullanıyoruz
        }

        //Konrolümüzün üstündeki yazıyı çizdiriyoruz  
        protected virtual void DrawText ( Graphics g )
        {
            //yazının sol kenara olan uzaklığını belirliyoruz
            int left = (buttonIcon == null) ? EDGE_PENDING : iconDrawWidth + EDGE_PENDING; //left adında değişken tanımlıyourz 
            int width = Width - left; //width adında int değişkeb tanımlıyourz ve leftten çıkarıyoruz
            int top = EDGE_PENDING;
            int height = Height - (2 * EDGE_PENDING);
            RectangleF layoutRect = new Rectangle(left, top, width, height);
            if(buttonState == ButtonState.Pushed)
                layoutRect.Offset(1, 1);
            //Yazının kontrol üzerindeki konumunu belirliyoruz
            StringFormat fmt = new StringFormat();
            fmt.Alignment = StringAlignment.Center;
            fmt.LineAlignment = StringAlignment.Center;
            SolidBrush textBrush = new SolidBrush(this.ForeColor);
            g.DrawString(Text, Font, textBrush, layoutRect, fmt);
            textBrush.Dispose(); //dispose ile ramdan textbrushı siliyoruz

           
        }

        //kontrolümüz aktif hala geldiğinde üzerine noktalı dikdörtgen (seçili olduğunu belirten) çizdiriyoruz
        protected virtual void DrawFocusClues ( Graphics g )
        {
            Pen p = new Pen(Color.Black, 1f);
            Rectangle frameRect = new Rectangle(0, 0, Width, Height);
            g.DrawRectangle(p, frameRect);
            p.DashStyle = DashStyle.Dot;
            frameRect = new Rectangle(2, 2, Width - 6, Height - 6);
            if(buttonState == ButtonState.Pushed)
                frameRect.Offset(1, 1);
            g.DrawRectangle(p, frameRect);
            p.Dispose();
        }
    }
}
