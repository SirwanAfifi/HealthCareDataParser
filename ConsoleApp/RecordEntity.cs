using System;

namespace ConsoleApp
{
    public class RecordEntity
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Unit { get; set; }
        public string Value { get; set; }
        public string SourceName { get; set; }
        public string SourceVersion { get; set; }
        public string Device { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}