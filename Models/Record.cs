using System;

namespace Models
{
    public class Record
    {
        public RecordType Type { get; set; }
        public Unit Unit { get; set; }
        public int Value { get; set; }
        public string SourceName { get; set; }
        public string SourceVersion { get; set; }
        public string Device { get; set; }
        public DateTimeOffset CreationDate { get; set; }
        public DateTimeOffset StartDate { get; set; }
        public DateTimeOffset EndDate { get; set; }
    }
}