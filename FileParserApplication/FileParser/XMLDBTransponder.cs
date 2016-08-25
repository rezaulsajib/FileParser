using System;

namespace FileParser
{
    public class XmldbTransponder : AbstractTransponder
    {
        public override void Parse()
        {
            Console.WriteLine("Parsing xml File..");
        }

        public override void Save()
        {
            Console.WriteLine("Saving Records in Database");
        }
    }
}
