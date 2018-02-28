using System;

namespace CsvToolDb.Models
{
    public class Approval
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Requestor { get; set; }
        public string Status { get; set; }
        public DateTime SubmittedDate { get; set; }
        public DateTime TaskSLADate { get; set; }
    }
}