using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using JokeApp.Models;

namespace JokeApp.Pages_Jokes
{

    public class IndexModel : PageModel
    {
        private readonly JokeApp.Models.AppDbContext _context;

        public IndexModel(JokeApp.Models.AppDbContext context)
        {
            _context = context;
        }

        public IList<Joke> Joke { get; set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Jokes != null)
            {
                Joke = await _context.Jokes
                .Include(j => j.Author).ToListAsync();
            }
        }
    }
}
