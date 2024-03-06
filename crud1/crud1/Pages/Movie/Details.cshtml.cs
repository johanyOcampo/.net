﻿using System;
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
    public class DetailsModel : PageModel
    {
        private readonly crud1.Data.crud1Context _context;

        public DetailsModel(crud1.Data.crud1Context context)
        {
            _context = context;
        }

      public Pelicula Pelicula { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Pelicula == null)
            {
                return NotFound();
            }

            var pelicula = await _context.Pelicula.FirstOrDefaultAsync(m => m.Id == id);
            if (pelicula == null)
            {
                return NotFound();
            }
            else 
            {
                Pelicula = pelicula;
            }
            return Page();
        }
    }
}
