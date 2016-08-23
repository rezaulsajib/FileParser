using System;

namespace FileParser
{
    public class ExcelEmailTransponder : AbstractTransponder
    {
        public override void Parse()
        {
            Console.WriteLine("Parsing Excel File..");
        }

        public override void Read()
        {
            Console.WriteLine("Reading Excel File from FTP server..");
        }

        public override void Save()
        {
            Console.WriteLine("Sending Records to email..");
        }
    }
}
