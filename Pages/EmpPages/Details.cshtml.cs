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
    public class DetailsModel : PageModel
    {
        private readonly employeewebapp.Data.employeewebappContext _context;

        public DetailsModel(employeewebapp.Data.employeewebappContext context)
        {
            _context = context;
        }

        public Employee Employee { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Employee = await _context.Employee.FirstOrDefaultAsync(m => m.ID == id);

            if (Employee == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
