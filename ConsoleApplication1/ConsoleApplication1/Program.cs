using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            DataTable dataTable = new DataTable("yourTabel");
            dataTable.Columns.Add("ID", typeof(int));
            dataTable.Columns.Add("name", typeof(string));
            dataTable.Columns.Add("Age", typeof(int));
            dataTable.Rows.Add(1, "john", 25);
            dataTable.Rows.Add(1, "honen", 35);
            foreach (DataRow row in dataTable.Rows) { 
            Console.WriteLine($"ID:{row["ID"]}),Name: {row["Name"]}, Age: {row["Age"]}");
        }
            Console.ReadLine();
        }
    }
}
