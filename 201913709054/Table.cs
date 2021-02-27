using System;
using System.Collections.Generic;
using System.Text;

namespace _201913709054.Database
{
   public class Table
    {
        public Row NewRow()
        {
            Row row = new Row();
            //her sütün için satırlara add methodu ile alan eklendi 
            foreach (Column sutun in Columns)
            {
                row.taban.Add(sutun.numara, "f");
            }
            return row;
        }
        new string numara;
        public Table(string numara)
        { 
            Columns = new List<Column>(); //yapıcı metotla sütunları tutacak bir nesne oluşturuldu
            Rows = new List<Row>(); //yapıcı metotla satırları tutacak bir nesne oluşturuldu
            this.numara= numara; //dışarıdaki numarayı gelen parametreye eşitleriz
        }
        public List<Column> Columns;
        public List<Row> Rows;
        
    }
}
