using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using CsvHelper;
using CsvHelper.Configuration;

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
