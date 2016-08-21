using System;

namespace FileParser
{
    public class DefaultParser
    {
        private void Read()
        {
            Console.WriteLine("Reading file from local storage");
        }

        private void Parse()
        {
            Console.WriteLine("Parsing file by default parser");
        }



        private void Save()
        {
            Console.WriteLine("Saving output file in local Storage");

        }

        public void Process()
        {
            Read();
            Parse();
            Save();
        }
    }
}
