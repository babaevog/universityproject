﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Univer.Data;
using Univer.Models;

namespace Univer.Pages.Students
{
    public class DetailsModel : PageModel
    {
        private readonly Univer.Data.SchoolContext _context;

        public DetailsModel(Univer.Data.SchoolContext context)
        {
            _context = context;
        }

      public Student Student { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Students == null)
            {
                return NotFound();
            }

            //Student = await _context.Students
            //    .Include(s => s.Enrollments)
            //    .ThenInclude(e  => e.Course)
            //    .AsNoTracking()
            //    .FirstOrDefaultAsync(m => m.Id == id);
            //if (Student == null)
            //{
            //    return NotFound();
            //}
            return Page();
        }
    }
}
