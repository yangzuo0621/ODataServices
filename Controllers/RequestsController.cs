using System.Linq;
using CsvToolDb.Models;
using Microsoft.AspNet.OData;
using Microsoft.EntityFrameworkCore;

namespace CsvToolDb.Controllers
{
    public class RequestsController : ODataController
    {
        private readonly CsvToolContext _context;

        public RequestsController(CsvToolContext context)
        {
            _context = context;
        }

        [EnableQuery]
        public IQueryable<Request> Get()
        {
            return _context.Requests.AsNoTracking().AsQueryable();
        }
    } 
}