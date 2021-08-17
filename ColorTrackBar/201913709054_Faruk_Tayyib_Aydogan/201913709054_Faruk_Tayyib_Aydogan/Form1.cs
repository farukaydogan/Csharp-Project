using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>
/// gerekli kütüphaneler çağrılıyor
/// </summary>


namespace _201913709054_Faruk_Tayyib_Aydogan
{/// <summary>
/// name space _201913709054_Faruk_Tayyib_Aydogan olarak belirleniyor yani diğer classlardan vs dosyaların birlikte değerlendireceği alan tanımlanıyor
/// </summary>
/// 
   
    public partial class Form1 : Form
    {/// <summary>
     /// Form'dan yeni Form1 çoklu sınıfımız olan Form1 Türetiliyor
     /// </summary>

     /// <summary>
     /// yapıcı class olan public form1 oluşturuluyor
     /// </summary>
        public Form1 ( )
        {
            InitializeComponent();
        }

        /// <summary>
        /// bu nesneleri burda oluşturmamızın sebebi metotların içerisinde bu nesnelere erişebilmektir= > label1 label2 label3 Trackbar1 Trackbar2 Trackbar3
        /// </summary>
        Label label1 = new Label();
        Label label2 = new Label();
        Label label3 = new Label();
        TrackBar TrackBar1 = new TrackBar();
        TrackBar TrackBar2 = new TrackBar();
        TrackBar TrackBar3 = new TrackBar();

        //button1 e tıklandığında yapmasını istediğimiz işlemleri yazıyoruz
        private void button1_Click ( object sender, EventArgs e )
        {
            timer1.Start();//timer1 ile 100 ms olan yineleme hızını başlatıyoruz ki renklerimiz düzenli olarak değişsin
                Controls.Remove(button1);// button1'e tıkladığımızda form1'den butonu kaldırıyoruz

            // label1Start olan bölge tanımlamasıdır
            #region label1Start 
            label1.ForeColor=Color.Red; // label1'in rengini kırmızı olarak atıyoruz
                label1.Location=new Point(33, 33); // label1'in locasyonunu nokta yordamı ile belirtiyoruz
            label1.Size=new Size(38, 20); // label1'in büyüklüğünü  belirtiyoruz
            label1.TabIndex=0; // label1'in tabindex numarasını yazıyoruz
            label1.Font = new Font(label1.Font, FontStyle.Bold); // label1'in fontunu bold olarak değiştirdik
            label1.Text="Red"; // label1'in yazı rengini kırmızı olarak belirliyoruz
            Controls.Add(label1);//kontrolümüze label'1 i ekliyoruz
            #endregion //bölge bitişidir

            // label2Start olan bölge tanımlamasıdır
            #region label2Start
            label2.ForeColor=Color.Green;  // label2'nin rengini yeşil olarak atıyoruz
            label2.Location=new Point(132, 33); // label2'nin locasyonunu nokta yordamı ile belirtiyoruz
            label2.Size=new Size(46, 20);  // label2'nin büyüklüğünü  belirtiyoruz
            label2.TabIndex=1; // label2'nin tabindex numarasını yazıyoruz
            label2.Font = new Font(label2.Font, FontStyle.Bold);// label2'nin fontunu bold olarak değiştirdik
            label2.Text="Green"; // label2'nin yazı rengini yeşil olarak belirliyoruz
            Controls.Add(label2); //kontrolümüze label'2 yi ekliyoruz
            #endregion //bölge bitişidir

            #region label3Start
            label3.ForeColor=Color.Blue; // label3'ün rengini mavi olarak atıyoruz
            label3.Location=new Point(243, 33);// label3'ün locasyonunu nokta yordamı ile belirtiyoruz
            label3.Size=new Size(46, 20);// label3'ün  büyüklüğünü  belirtiyoruz
            label3.TabIndex=2;// label3'ün tabindex numarasını yazıyoruz
            label3.Font = new Font(label3.Font,  FontStyle.Bold);// label3'ün fontunu bold olarak değiştirdik
            label3.Text="Blue";// label3'ün yazı rengini mavi olarak belirliyoruz
            Controls.Add(label3);//  kontrolümüze label3'ü ekliyroruz
            #endregion //bölge bitişidir

            #region TrackBar1Created
            TrackBar1.Location=new Point(24, 71); //trackbar1 in locasyonu belirleniyor
                TrackBar1.Maximum=255; //trackbarın maximum değeri belirleniyor
                TrackBar1.Minimum=0; //trackbarın min değeri belirleniyor
                TrackBar1.Size= new Size(56, 285); //trackbarın size'ı belirleniyor
                TrackBar1.TabIndex=3; //trackbarın tab index değerini beliriyoruz
                TrackBar1.TickStyle=TickStyle.Both;//trackbarın tickstyle'ı both olarak ayarlanıyor
                TrackBar1.BackColor=Color.Red; //trackbarın rengi red olarak ayarlanıyoruz
                TrackBar1.Orientation=Orientation.Vertical; //trackbarı dikey olarak ayarlıyoruz

            Controls.Add(TrackBar1);//controle trackbar ekleniyor

                #endregion
                #region TrackBar2Created
                TrackBar2.Location=new Point(134, 71); //trackbar2 in locasyonu belirleniyor
            TrackBar2.Maximum=255; //trackbarın maximum değeri belirleniyor
            TrackBar2.Minimum=0;  //trackbarın min değeri belirleniyor
            TrackBar2.Size= new Size(56, 285); //trackbarın size'ı belirleniyor
            TrackBar2.TabIndex=4;//trackbarın tab index değerini beliriyoruz
            TrackBar2.TickStyle=TickStyle.Both;//trackbarın tickstyle'ı both olarak ayarlanıyor
            TrackBar2.BackColor=Color.Green; //trackbarın rengi yeşil olarak ayarlanıyoruz
            TrackBar2.Orientation=Orientation.Vertical;  //trackbarı dikey olarak ayarlıyoruz

            Controls.Add(TrackBar2);//controle trackbar ekleniyor

            #endregion
            #region TrackBar2Created
            TrackBar3.Location=new Point(243, 71);  //trackbar3 in locasyonu belirleniyor
            TrackBar3.Maximum=255; //trackbarın maximum değeri belirleniyor
            TrackBar3.Minimum=0;  //trackbarın min değeri belirleniyor
            TrackBar3.Size= new Size(56, 285); //trackbarın size'ı belirleniyor
            TrackBar3.TabIndex=5;//trackbarın tab index değerini beliriyoruz
            TrackBar3.TickStyle=TickStyle.Both; //trackbarın tickstyle'ı both olarak ayarlanıyor
            TrackBar3.BackColor=Color.Blue; //trackbarın rengi mavi olarak ayarlanıyoruz
            TrackBar3.Orientation=Orientation.Vertical;  //trackbarı dikey olarak ayarlıyoruz
            Controls.Add(TrackBar3);//controle trackbar ekleniyor
            #endregion
        }

      
        private void timer1_Tick ( object sender, EventArgs e ) //timer1 değiştikçe gerekli işlemleri yapması için bu metot kullanılacaktır
        {
            
            label1.ForeColor=ColorTranslator.FromHtml("#"+DecToHex(TrackBar1.Value.ToString())+"0000"); //label'1in yazı rengi hex kod olarak gerekli metotlar ile belirleniyor
            label2.ForeColor=ColorTranslator.FromHtml("#"+"00"+DecToHex(TrackBar2.Value.ToString())+"00");//label2'nin yazı rengi hex kod olarak gerekli metotlar ile belirleniyor
            label3.ForeColor=ColorTranslator.FromHtml("#"+"0000"+DecToHex(TrackBar3.Value.ToString())); //label3'ün  yazı rengi hex kod olarak gerekli metotlar ile belirleniyor
            try //dene ile formun arkaplan rengi belirleniyor 
            {
                BackColor =  ColorTranslator.FromHtml("#"+DecToHex(TrackBar1.Value.ToString())+DecToHex(TrackBar2.Value.ToString())+DecToHex(TrackBar3.Value.ToString()));
                //backcolor rengi hex kodu ile gerekli işlemlerle çeviriliyor
            }
            catch(Exception)
            {
                //eğer hata alırsak formu durdurmayarak direkt olarak devam edecektir
            }
        }

        /// <summary>
        /// bu metoda decimal olarak bir string gönderiyoruz ve geri çıktısı olarak Hexadecimal yani 16'lık bir sayı geri dönecektir        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private string DecToHex(string value)
        {
            string decimalNumber = value; //string tipinde decimalNumber adında bir değişken oluşturduk ve bunuda gelen sayıya eşitledik
            int number1 = int.Parse(decimalNumber); // int tipinde number1 adında değişkenb oluşturuyoruz ve bunu int.parse yöntemi ile int tipine dönüştürdük
            string hex = number1.ToString("x");//burada hex olarak string tipinde değişken oluşturuyoruz ve bu number1 değişkenini hex'e ardından stringe dönüştürmüş olduk
            if(Convert.ToInt32(value)<17) //sayı 17den küçükse bu kod bloğu çalışacaktır bunu yapmamın sebebi ise iki basamaklı bir değer dönmesi gereklidir
            { return "0"+hex; } // geri dönecek olan değeri belirtiyoruz
            else //eğer 17den büyükse direkt olarak hex dönecektir
            {
                return hex; //hex geri dönecektir
            }
        }
        private void Form1_Load ( object sender, EventArgs e )
        {
        }
    }
}
