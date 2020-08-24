using CsvHelper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using TaxitripApi.Models;

namespace TaxitripApi.Handlers
{
    public static class StartupTaxiDatabase
    {
        public static string taxiFileName = $"{AppDomain.CurrentDomain.BaseDirectory}/Config/yellow_tripdata.csv";
        public static void Setup()
        {
            ImportCsvFile(taxiFileName);
        }

        public static void ImportCsvFile(string filename)
        {
            using (TextReader csvreader1 = File.OpenText(taxiFileName))
            using (CsvReader csvR1 = new CsvReader(csvreader1, CultureInfo.InvariantCulture))
            {
                foreach (TaxiTrip record in csvR1.GetRecords<TaxiTrip>())
                {
                    //do whatever with the single record
                }
            }
        }
    }
}
