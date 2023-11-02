using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesPizza.Data;
using RazorPagesPizza.Models;

namespace RazorPagesPizzaDb.Pages.Pizza
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesPizza.Data.PizzaContext _context;

        public IndexModel(RazorPagesPizza.Data.PizzaContext context)
        {
            _context = context;
        }

        public IList<PizzaContext> Pizza { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Pizza != null)
            {
                Pizza = (IList<PizzaContext>)await _context.Pizza.ToListAsync();
            }
        }
    }
}
