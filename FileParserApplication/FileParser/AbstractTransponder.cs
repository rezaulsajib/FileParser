using System;

namespace FileParser
{
    public abstract class AbstractTransponder
    {
        public virtual void Read()
        {
            Console.WriteLine("Reading file from local storage");
        }
        public abstract void Parse();
        
        public abstract void Save();
        

        public  void Process()
        {
            Read();
            Parse();
            Save();
        }
    }
}
