using eTicket.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTicket.Controllers
{
    public class CinemasController1 : Controller
    {
        private readonly AppDbContext _context;

        public CinemasController1(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _context.Cinemas.ToListAsync();
            return View();
        }
    }
}
