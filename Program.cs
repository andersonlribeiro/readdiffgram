using System;
using System.IO;
using System.Threading.Tasks;
using System.Data;

namespace diffgram
{
    class Program
    {
        static async Task Main(string[] args)
        {
            //read xml sample
            string xmlContent = await File.ReadAllTextAsync("diffgram.xml");
            //creates a dataset object
            DataSet myDataSet = new DataSet();
            DataTable tbl = myDataSet.Tables.Add("pokemon_characters");
            //create table columns
            tbl.Columns.Add("CODE", typeof(int));
            tbl.Columns.Add("DESCRIPTION", typeof(string));
            //read xml and save data into dataset.
            myDataSet.ReadXml(new StringReader(xmlContent), XmlReadMode.Auto);
            myDataSet.AcceptChanges();
            //show dataset values.
            PrintValues(myDataSet, "Dataset");
        }

        
        private static void PrintValues(DataSet dataSet, string label)
        {
            Console.WriteLine("\n" + label);
            foreach (DataTable table in dataSet.Tables)
            {
                Console.WriteLine("### POCKEMON CHARACTER LIST ###");
                foreach (DataRow row in table.Rows)
                {
                    Console.WriteLine($"Code: { row["code"] } Character:  { row["DESCRIPTION"] }");
                }
            }
        }
    }
}
