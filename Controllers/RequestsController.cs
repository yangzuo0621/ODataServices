using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using CsvToolDb.Models;
using Microsoft.AspNet.OData;

namespace CsvToolDb.Controllers
{
    public class RequestsController : ODataController
    {
        // private readonly CsvToolContext _context;

        // public RequestsController(CsvToolContext context)
        // {
        //     _context = context;
        // }

        [EnableQuery]
        public IEnumerable<Request> Get()
        {
            // return _context.Requests.AsNoTracking().AsQueryable();
            List<Request> requests = new List<Request>();
            
            using (SqlConnection con = new SqlConnection("Server=(localdb)\\mssqllocaldb;Database=CsvToolDb.TestDb;Trusted_Connection=True;"))
            {
                SqlCommand cmd = new SqlCommand("GetRequests", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Request r = new Request();
                    r.Id = rdr["Id"].ToString();
                    r.Title = rdr["Title"].ToString();
                    r.Brand = rdr["Brand"].ToString();
                    r.Status = rdr["Status"].ToString();

                    DateTime.TryParse(rdr["CreatedDate"].ToString(), out DateTime CreatedDate);
                    r.CreatedDate = CreatedDate;

                    DateTime.TryParse(rdr["CreatedDate"].ToString(), out DateTime SubmittedDate);
                    r.SubmittedDate = SubmittedDate;

                    DateTime.TryParse(rdr["CreatedDate"].ToString(), out DateTime TaskSLADate);
                    r.TaskSLADate = TaskSLADate;

                    r.ReportBack = rdr["TaskSLADate"].ToString();

                    requests.Add(r);
                }
                con.Close();
            }
            return requests; 
        }
    } 
}