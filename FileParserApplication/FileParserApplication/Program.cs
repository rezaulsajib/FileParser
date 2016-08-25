using System;
using FileParser;

namespace FileParserApplication
{
    class Program
    {
        /// <summary>
        /// Transponder application
        /// 
        /// Source:
        ///             1- Local storage
        ///             2- FTP Server
        ///  File Type:
        ///             1- CSV
        ///             2- Excel
        ///             3- Xml
        ///  Save:
        ///             1- Database
        ///             2- Email
        /// </summary>
        /// <param name="args"></param>

        static void Main(string[] args)
        {
            Console.WriteLine("\tTransponder Application");
            Console.WriteLine("\tSource:"+
                     "\n\t\t1- Local storage"+
                     "\n\t\t2- FTP Server");
            Console.WriteLine("\tFile Type:" +
                    "\n\t\t1- CSV" +
                    "\n\t\t2- Excel" +
                    "\n\t\t3- Xml");
            Console.WriteLine("\tSave Option:" +
                    "\n\t\t1- Database" +
                    "\n\t\t2- Email");
            Console.WriteLine("\tInput:" +
                    "\n\t\t{source},{fileType},{saveOption}" +
                    "\n\t\tExample: 1,1,1");
            Console.WriteLine("press q to quit");
            try
            {

                var inputStr = Console.ReadLine();
                while (inputStr!="q")
                {
                    if (inputStr == null) continue;
                    var inputChar = inputStr.Split(',');
                    var source = Convert.ToInt32(inputChar[0]);
                    var fileType = Convert.ToInt32(inputChar[1]);
                    var save = Convert.ToInt32(inputChar[2]);
                    var transponder = TransponderFactory.CreateTransponder(source, fileType, save);
                    transponder.Process();
                    inputStr = Console.ReadLine();
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }

        }
    }
    public static class TransponderFactory
    {
        public static AbstractTransponder CreateTransponder(int source,int fileType,int saveOption)
        {
            if (source == 1 && fileType == 1 && saveOption == 1)
                return new CsvTransponder();
            if (source == 2 && fileType == 2 && saveOption == 2)
                return new ExcelEmailTransponder();
            if (source == 1 && fileType == 3 && saveOption == 1)
                return new XmldbTransponder();
            throw new NotSupportedException("No supported Transponder Found");
        }

    }
}
