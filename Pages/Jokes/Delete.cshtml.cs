using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using JokeApp.Models;
using Microsoft.AspNetCore.Authorization;

namespace JokeApp.Pages_Jokes
{
    [Authorize]
    public class DeleteModel : PageModel
    {
        private readonly JokeApp.Models.AppDbContext _context;

        public DeleteModel(JokeApp.Models.AppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Joke Joke { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Jokes == null)
            {
                return NotFound();
            }

            var joke = await _context.Jokes.FirstOrDefaultAsync(m => m.Id == id);

            if (joke == null)
            {
                return NotFound();
            }
            else
            {
                Joke = joke;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Jokes == null)
            {
                return NotFound();
            }
            var joke = await _context.Jokes.FindAsync(id);

            if (joke != null)
            {
                Joke = joke;
                _context.Jokes.Remove(Joke);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
