using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using CsvHelper;
using CsvHelper.Configuration;

namespace FileParser
{
    public class DefaultParser
    {
        private List<DataRecord> _dataRecord = new List<DataRecord>();
        
        private void Read()
        {
            var configuration = new CsvConfiguration {Delimiter = ","};
            Console.WriteLine("Reading file from local storage");
            using (var sr = new StreamReader(@"countrylist.csv"))
            {

                var reader = new CsvReader(sr, configuration);
                _dataRecord = reader.GetRecords<DataRecord>().ToList();


            }
        }

        private void Parse()
        {
            Console.WriteLine("Parsing file by default parser");
        }



        private void Save()
        {
            Console.WriteLine("Common Name\tFormal Name\tCountry Code");
            foreach (var dataRecord in _dataRecord)
            {
                Console.WriteLine("{0}\t {1}\t {2}",dataRecord.CommonName,
                    dataRecord.FormalName,dataRecord.CountryCode);
            }

        }

        public void Process()
        {
            Read();
            Parse();
            Save();
        }
    }
}
