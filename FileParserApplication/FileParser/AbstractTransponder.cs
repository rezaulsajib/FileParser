namespace FileParser
{
    public abstract class AbstractTransponder
    {
        public abstract void Parse();
        public abstract void Read();
        public abstract void Save();
        

        public  void Process()
        {
            Parse();
            Read();
            Save();
        }
    }
}
