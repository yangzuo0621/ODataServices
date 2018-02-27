using System;

namespace CsvToolDb.Models 
{
    public class Request
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Status { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? SubmittedDate { get; set; }
        public DateTime? TaskSLADate { get; set; }
        public string ReportBack { get; set; }
    }
}