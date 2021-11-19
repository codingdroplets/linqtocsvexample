using LINQtoCSV;
using System;

namespace CsvDemo
{
    [Serializable]
    public class Country
    {
        [CsvColumn(Name = "name", FieldIndex = 1)]
        public string CountryName { get; set; }

        [CsvColumn(Name = "alpha-2", FieldIndex = 2)]
        public string Alpha2 { get; set; }

        [CsvColumn(Name = "alpha-3", FieldIndex = 3)]
        public string Alpha3 { get; set; }

        [CsvColumn(Name = "country-code", FieldIndex = 4)]
        public string CountryCode { get; set; }

        [CsvColumn(Name = "region", FieldIndex = 5)]
        public string Region { get; set; }
    }
}
