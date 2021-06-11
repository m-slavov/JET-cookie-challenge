using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using JETCookies.Models;

namespace JETCookies.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CookiesController : ControllerBase
    {
        private readonly DataContext _context;

        public CookiesController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Cookies
        [HttpGet]
        public IActionResult GetAll()
        {
            var cookielist = _context.CookieItems.Select(o => new
            {
                o.Id,
                o.Name,
                o.Weight,
                o.Calories,
                Ingredient = o.CookieIngredients.Select(ot => ot.Ingredient).ToList()
            }).ToList();

            return Ok(cookielist);
        }

        private bool CookieExists(int id)
        {
            return _context.CookieItems.Any(e => e.Id == id);
        }
    }
}
