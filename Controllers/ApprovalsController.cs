using System.Collections.Generic;
using System.Linq;
using CsvToolDb.Models;
using Microsoft.AspNet.OData;
using Microsoft.EntityFrameworkCore;

namespace CsvToolDb.Controllers
{
    public class ApprovalsController : ODataController
    {
        private readonly CsvToolContext _context;

        public ApprovalsController(CsvToolContext context)
        {
            _context = context;
        }

        [EnableQuery]
        public List<Approval> Get()
        {
            return _context.Approvals.AsNoTracking().ToList();
        }
    }
}
