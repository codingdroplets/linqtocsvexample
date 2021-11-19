using LINQtoCSV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsvDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ReadCsvFile();
            WriteCsvFile();
            Console.ReadKey();
        }

        private static void WriteCsvFile()
        {
            var countryList = new List<Country>
            {
                new Country{ CountryName = "Afghanistan", Alpha2 = "AF", Alpha3 = "AFG", CountryCode = "4", Region = "Asia"},
                new Country{ CountryName = "Åland Islands", Alpha2 = "AI", Alpha3 = "AIS", CountryCode = "5", Region = "Asia"},
                new Country{ CountryName = "Albania", Alpha2 = "AB", Alpha3 = "ALB", CountryCode = "6", Region = "Asia"}
            };

            var csvFileDescription = new CsvFileDescription
            {
                FirstLineHasColumnNames = true,
                SeparatorChar = ','
            };

            var csvContext = new CsvContext();
            csvContext.Write(countryList, "country01.csv", csvFileDescription);

            Console.WriteLine("CSV File Created");
        }

        private static void ReadCsvFile()
        {
            var csvFileDescription = new CsvFileDescription
            {
                FirstLineHasColumnNames = true,
                IgnoreUnknownColumns = true,
                SeparatorChar = ',',
                UseFieldIndexForReadingData = false
            };

            var csvContext = new CsvContext();
            var countries = csvContext.Read<Country>("country.csv", csvFileDescription);

            foreach(var country in countries)
            {
                Console.WriteLine($"{country.CountryName} | {country.Alpha3} | {country.CountryCode}");
            }
        }
    }
}
