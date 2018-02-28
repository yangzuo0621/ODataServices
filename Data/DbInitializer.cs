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
                new Request { Id="CSVRW00211", Title="CSV 2", Brand="MS", Status="Draft", CreatedDate=DateTime.Parse("2017-12-01"), ReportBack="" },
                new Request { Id="CSVRW00212", Title="Test Mandy", Brand="MS", Status="Pending for more info", CreatedDate=DateTime.Parse("2017-12-12"), SubmittedDate=DateTime.Parse("2018-01-12"), TaskSLADate=DateTime.Parse("2017-12-30"), ReportBack="" },
                new Request { Id="CSVRW00213", Title="Test workflow", Brand="MS", Status="In Progress", CreatedDate=DateTime.Parse("2017-12-13"), SubmittedDate=DateTime.Parse("2018-01-14"), TaskSLADate=DateTime.Parse("2017-12-30"), ReportBack="Submitted" },
                new Request { Id="CSVRW00214", Title="Test request", Brand="MS", Status="In Progress", CreatedDate=DateTime.Parse("2017-12-14"), SubmittedDate=DateTime.Parse("2018-01-11"), TaskSLADate=DateTime.Parse("2017-12-30"), ReportBack="Submitted" },
                new Request { Id="CSVRW00215", Title="Test request 2", Brand="ABC", Status="Approved", CreatedDate=DateTime.Parse("2017-12-15"), SubmittedDate=DateTime.Parse("2018-01-11"), TaskSLADate=DateTime.Parse("2017-12-30"), ReportBack="Submitted" },
                new Request { Id="CSVRW00216", Title="Test request 2", Brand="MS", Status="Denied", CreatedDate=DateTime.Parse("2017-12-11"), SubmittedDate=DateTime.Parse("2018-01-19"), TaskSLADate=DateTime.Parse("2017-12-30"), ReportBack="" },
                new Request { Id="CSVRW00217", Title="CSV 2", Brand="MS", Status="Draft", CreatedDate=DateTime.Parse("2017-12-09"), ReportBack="Submitted" },
                new Request { Id="CSVRW00218", Title="Test Mandy", Brand="IVT", Status="In Progress", CreatedDate=DateTime.Parse("2017-12-04"), SubmittedDate=DateTime.Parse("2018-01-12"), TaskSLADate=DateTime.Parse("2017-12-30"), ReportBack="Submitted" },
                new Request { Id="CSVRW00219", Title="title1", Brand="MS", Status="In Progress", CreatedDate=DateTime.Parse("2017-12-01"), SubmittedDate=DateTime.Parse("2018-01-12"), TaskSLADate=DateTime.Parse("2017-12-30"), ReportBack="Submitted" },
                new Request { Id="CSVRW00220", Title="title2", Brand="Test", Status="In Progress", CreatedDate=DateTime.Parse("2017-12-12"), SubmittedDate=DateTime.Parse("2018-01-05"), TaskSLADate=DateTime.Parse("2017-12-30"), ReportBack="" },
                new Request { Id="CSVRW00221", Title="title3", Brand="GXXX", Status="Pending for more info", CreatedDate=DateTime.Parse("2017-12-20"), SubmittedDate=DateTime.Parse("2018-01-09"), TaskSLADate=DateTime.Parse("2017-12-30"), ReportBack="Submitted" },
                new Request { Id="CSVRW00222", Title="title4", Brand="GXXX", Status="In Progress", CreatedDate=DateTime.Parse("2017-12-12"), SubmittedDate=DateTime.Parse("2018-01-22"), TaskSLADate=DateTime.Parse("2017-12-30"), ReportBack="Submitted" },
            };

            foreach (Request r in requests)
            {
                context.Requests.Add(r);
            }
            context.SaveChanges();

            var approvals = new Approval[]
            {
                new Approval { Id="CSVRW00211", Title="Test 1", Requestor="Mandy Wu", Status="In Progress", SubmittedDate=DateTime.Parse("2017-12-01"), TaskSLADate=DateTime.Parse("2017-12-01") },
                new Approval { Id="CSVRW00212", Title="Test 2", Requestor="Mandy Wu", Status="Denied", SubmittedDate=DateTime.Parse("2017-12-01"), TaskSLADate=DateTime.Parse("2017-12-01") },
                new Approval { Id="CSVRW00213", Title="Test 3", Requestor="Mandy Wu", Status="Denied", SubmittedDate=DateTime.Parse("2017-12-01"), TaskSLADate=DateTime.Parse("2017-12-01") },
                new Approval { Id="CSVRW00214", Title="Test 4", Requestor="Mao Li", Status="In Progress", SubmittedDate=DateTime.Parse("2017-12-01"), TaskSLADate=DateTime.Parse("2017-12-01") },
                new Approval { Id="CSVRW00215", Title="Test 5", Requestor="Mao Li", Status="In Progress", SubmittedDate=DateTime.Parse("2017-12-01"), TaskSLADate=DateTime.Parse("2017-12-01") },
                new Approval { Id="CSVRW00216", Title="Test 6", Requestor="Mao Li", Status="In Progress", SubmittedDate=DateTime.Parse("2017-12-01"), TaskSLADate=DateTime.Parse("2017-12-01") },
                new Approval { Id="CSVRW00217", Title="Test 7", Requestor="Mao Li", Status="In Progress", SubmittedDate=DateTime.Parse("2017-12-01"), TaskSLADate=DateTime.Parse("2017-12-01") },
                new Approval { Id="CSVRW00218", Title="Test 8", Requestor="Mandy Wu", Status="In Progress", SubmittedDate=DateTime.Parse("2017-12-01"), TaskSLADate=DateTime.Parse("2017-12-01") },
                new Approval { Id="CSVRW00219", Title="Test 9", Requestor="Mandy Wu", Status="Approved", SubmittedDate=DateTime.Parse("2017-12-01"), TaskSLADate=DateTime.Parse("2017-12-01") },
                new Approval { Id="CSVRW00210", Title="Test request", Requestor="Mandy Wu", Status="In Progress", SubmittedDate=DateTime.Parse("2017-12-01"), TaskSLADate=DateTime.Parse("2017-12-01") },
                new Approval { Id="CSVRW00221", Title="Test workflow", Requestor="Mandy Wu", Status="Pending for more information", SubmittedDate=DateTime.Parse("2017-12-01"), TaskSLADate=DateTime.Parse("2017-12-01") },
                new Approval { Id="CSVRW00222", Title="Test Mandy", Requestor="Mandy Wu", Status="In Progress", SubmittedDate=DateTime.Parse("2017-12-01"), TaskSLADate=DateTime.Parse("2017-12-01") },
                new Approval { Id="CSVRW00223", Title="Test 1", Requestor="Mandy Wu", Status="In Progress", SubmittedDate=DateTime.Parse("2017-12-01"), TaskSLADate=DateTime.Parse("2017-12-01") }
            };
            foreach (Approval a in approvals)
            {
                context.Approvals.Add(a);
            }
            context.SaveChanges();
        }
    }
}