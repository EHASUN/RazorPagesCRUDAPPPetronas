using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using employeewebapp.Data;
using employeewebapp.Models;

namespace employeewebapp.Pages.EmpPages
{
    public class IndexModel : PageModel
    {
        private readonly employeewebapp.Data.employeewebappContext _context;

        public IndexModel(employeewebapp.Data.employeewebappContext context)
        {
            _context = context;
        }

        public IList<Employee> Employee { get;set; }

        public async Task OnGetAsync()
        {
            Employee = await _context.Employee.ToListAsync();
        }
    }
}
