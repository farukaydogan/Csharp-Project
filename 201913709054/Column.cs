using System;
using System.Collections.Generic;
using System.Text;

namespace _201913709054.Database
{
    public class Column
    {
        public string numara;  // sütunları belirlemek için numara adında değişken oluşturuldu
        public Column(string numara)  //tek parametreli yapıcı metot oluşturuldu
        {
            this.numara = numara;  //dışarıdaki numarayı gelen parametreye eşitleriz
        }
    }
}
