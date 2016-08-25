using System;

namespace FileParser
{
    public class CsvTransponder: AbstractTransponder
    {
       
       

        public override void Parse()
        {
            Console.WriteLine("Parsing file by csv parser");
           
        }

        public override void Save()
        {
            Console.WriteLine("Saving Records in database");
          
        }

      
    }
}
