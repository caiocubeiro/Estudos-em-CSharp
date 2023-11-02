using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorPagesPizza.Data;
using RazorPagesPizza.Models;
using RazorPagesPizza.Services;

namespace RazorPagesPizzaDb.Pages.Pizza
{
    public class CreateModel : PageModel
    {
        private readonly RazorPagesPizza.Data.PizzaContext _context;

        public CreateModel(RazorPagesPizza.Data.PizzaContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public PizzaContext Pizza { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Pizza == null || Pizza == null)
            {
                return Page();
            }

            _context.Pizza.Add(Pizza);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
