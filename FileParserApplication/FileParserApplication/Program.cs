using FileParser;

namespace FileParserApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var defaultParser = new DefaultParser();
            defaultParser.Process();

        }
    }
}
