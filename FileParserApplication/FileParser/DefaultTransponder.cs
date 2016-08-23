using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using CsvHelper;
using CsvHelper.Configuration;

namespace FileParser
{
    public class DefaultTransponder: AbstractTransponder
    {
       
        public override void Read()
        {
           
            Console.WriteLine("Reading file from local storage");
           
        }

        public override void Parse()
        {
            Console.WriteLine("Parsing file by default parser");
           
        }

        public override void Save()
        {
            Console.WriteLine("Saving Records in database");
          
        }

      
    }
}
