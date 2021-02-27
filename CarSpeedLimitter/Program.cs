using System;
using System.Threading;

namespace _21_02_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            Araba arb = new Araba();
            arb.evt += new delege(hizasirtma);

            for (int i = 80; i <= 150; i += 5)
            {
                arb.Hiz = i;
                Console.WriteLine(arb.Hiz);
                Thread.Sleep(100);
            }
        }
        public static void hizasirtma(object sender, HizArgs arg)
        {
            Console.WriteLine($"hiziniz hız sınırını aşmışsınız"+arg.GuncelHiz+"\t" + arg.zaman);
        }

    }

    public class HizArgs
    {
        public int hiz;
        public HizArgs(int x)
        {
            hiz = x ;
        }
        public DateTime zaman
        {
            get
            {
                return DateTime.Now;
            }
        }
        public int GuncelHiz

        {
            get { return hiz; }
        }
    }
    public delegate void delege(object sender, HizArgs arg);

    class Araba
    {
        public event delege evt;
        int hiz;
        public int Hiz
        {
            get { return hiz; }
            set
            {
                if (hiz >=120)
                {
                    evt(this, new HizArgs(value));
                }
                hiz = value;
            }
        }


    }
}
