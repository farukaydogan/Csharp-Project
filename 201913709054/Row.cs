using System;
using System.Collections.Generic;
using System.Text;

namespace _201913709054.Database
{
    public class Row
    {
        public string this[string indexer]
        {
            get { return taban[indexer]; }//return edilecek değer get ediliyor
            set { taban[indexer] = value; } //indexer değeri set edildi
        }
        public IDictionary<string, string> taban;
        public Row() //yapıcı metot oluşturuldu
        {
            taban = new Dictionary<string, string>(); //taban adında sözlük oluşturuldu string türünde
        }
        
    }
}
