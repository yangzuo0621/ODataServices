using System;
using System.Linq;
using CsvToolDb.Models;

namespace CsvToolDb.Data
{
    public static class DbInitializer
    {
        public static void Initialize(CsvToolContext context)
        {
            if (context.Requests.Any())
            {
                return;
            }

            var requests = new Request[]
            {
                new Request { Id="CSVRW00211", Title="CSV 2", Status="Draft", CreatedDate=DateTime.Parse("2017-12-01"), ReportBack="" },
                new Request { Id="CSVRW00212", Title="Test Mandy", Status="Pending for more info", CreatedDate=DateTime.Parse("2017-12-12"), SubmittedDate=DateTime.Parse("2018-01-12"), TaskSLADate=DateTime.Parse("2017-12-30"), ReportBack="" },
                new Request { Id="CSVRW00213", Title="Test workflow", Status="In Progress", CreatedDate=DateTime.Parse("2017-12-13"), SubmittedDate=DateTime.Parse("2018-01-14"), TaskSLADate=DateTime.Parse("2017-12-30"), ReportBack="Submitted" },
                new Request { Id="CSVRW00214", Title="Test request", Status="In Progress", CreatedDate=DateTime.Parse("2017-12-14"), SubmittedDate=DateTime.Parse("2018-01-11"), TaskSLADate=DateTime.Parse("2017-12-30"), ReportBack="Submitted" },
                new Request { Id="CSVRW00215", Title="Test request 2", Status="Approved", CreatedDate=DateTime.Parse("2017-12-15"), SubmittedDate=DateTime.Parse("2018-01-11"), TaskSLADate=DateTime.Parse("2017-12-30"), ReportBack="Submitted" },
                new Request { Id="CSVRW00216", Title="Test request 2", Status="Denied", CreatedDate=DateTime.Parse("2017-12-11"), SubmittedDate=DateTime.Parse("2018-01-19"), TaskSLADate=DateTime.Parse("2017-12-30"), ReportBack="" },
                new Request { Id="CSVRW00217", Title="CSV 2", Status="Draft", CreatedDate=DateTime.Parse("2017-12-09"), ReportBack="Submitted" },
                new Request { Id="CSVRW00218", Title="Test Mandy", Status="In Progress", CreatedDate=DateTime.Parse("2017-12-04"), SubmittedDate=DateTime.Parse("2018-01-12"), TaskSLADate=DateTime.Parse("2017-12-30"), ReportBack="Submitted" },
                new Request { Id="CSVRW00219", Title="title1", Status="In Progress", CreatedDate=DateTime.Parse("2017-12-01"), SubmittedDate=DateTime.Parse("2018-01-12"), TaskSLADate=DateTime.Parse("2017-12-30"), ReportBack="Submitted" },
                new Request { Id="CSVRW00220", Title="title2", Status="In Progress", CreatedDate=DateTime.Parse("2017-12-12"), SubmittedDate=DateTime.Parse("2018-01-05"), TaskSLADate=DateTime.Parse("2017-12-30"), ReportBack="" },
                new Request { Id="CSVRW00221", Title="title3", Status="Pending for more info", CreatedDate=DateTime.Parse("2017-12-20"), SubmittedDate=DateTime.Parse("2018-01-09"), TaskSLADate=DateTime.Parse("2017-12-30"), ReportBack="Submitted" },
                new Request { Id="CSVRW00222", Title="title4", Status="In Progress", CreatedDate=DateTime.Parse("2017-12-12"), SubmittedDate=DateTime.Parse("2018-01-22"), TaskSLADate=DateTime.Parse("2017-12-30"), ReportBack="Submitted" },
            };

            foreach (Request r in requests)
            {
                context.Requests.Add(r);
            }
            context.SaveChanges();
        }
    }
}