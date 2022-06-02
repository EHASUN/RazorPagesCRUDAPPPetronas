using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using employeewebapp.Data;
using employeewebapp.Models;

namespace employeewebapp.Pages.EmpPages
{
    public class CreateModel : PageModel
    {
        private readonly employeewebapp.Data.employeewebappContext _context;

        public CreateModel(employeewebapp.Data.employeewebappContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Employee Employee { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Employee.Add(Employee);
            //await _context.SaveChangesAsync();

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {

                // return NotFound();
                return RedirectToPage("./Index");

            }

            return RedirectToPage("./Index");
        }
    }
}
