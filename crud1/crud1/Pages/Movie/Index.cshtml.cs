using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using crud1.Data;
using crud1.Models;

namespace crud1.Pages.Movie
{
    public class IndexModel : PageModel
    {
        private readonly crud1.Data.crud1Context _context;

        public IndexModel(crud1.Data.crud1Context context)
        {
            _context = context;
        }

        public IList<Pelicula> Pelicula { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Pelicula != null)
            {
                Pelicula = await _context.Pelicula.ToListAsync();
            }
        }
    }
}
