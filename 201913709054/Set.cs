using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace _201913709054.Database
{
    public class Set  
    {
        public Set(string numara) // liste için yapıcı metot oluşturuldu 
        {
            this.numara = numara;
            //Liste Başlatıldı 
            Tables = new List<Table>();
        }
        public List<Table> Tables;
        string numara;
       
    }
}
