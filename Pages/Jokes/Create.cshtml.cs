using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using JokeApp.Models;
using Microsoft.AspNetCore.Authorization;

namespace JokeApp.Pages_Jokes
{
    [Authorize]
    public class CreateModel : PageModel
    {
        private readonly JokeApp.Models.AppDbContext _context;

        public CreateModel(JokeApp.Models.AppDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            ViewData["AuthorId"] = new SelectList(_context.Users, "Id", "Id");
            return Page();
        }

        [BindProperty]
        public Joke Joke { get; set; } = default!;


        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid || _context.Jokes == null || Joke == null)
            {
                return Page();
            }

            _context.Jokes.Add(Joke);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
