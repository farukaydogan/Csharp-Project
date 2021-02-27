using System;

namespace _201913709054.Database
{
    class Program
    {
        static void Main(string[] args)
        {
            Set set = new Set("DbSchool");
            Table table = new Table("Tablename");
            set.Tables.Add(table);
            table.Columns.Add(new Column("No"));
            table.Columns.Add(new Column("Name"));
            Row row = table.NewRow();
            row["No"] = "123";
            row["Name"] = "X";
            table.Rows.Add(row);
            Row row2 = table.NewRow();
            row2["No"] = "456";
            row2["Name"] = "Y";
            table.Rows.Add(row2);
            table.Rows[1]["No"] ="345";
            foreach  (Row urun in table.Rows)
            { 
                Console.WriteLine("No:{0} \t Name :{1} ",urun["No"],urun["Name"]);
            }
            Console.WriteLine();
          //     Console.WriteLine(set.Tables["TblStudents"].Rows[1]["No"]); ;
          
        }
    }
   
}
