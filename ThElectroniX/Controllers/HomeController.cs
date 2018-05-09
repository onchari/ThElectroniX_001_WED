using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThElectroniX.Data;

namespace ThElectroniX.Controllers
{
    public class HomeController : Controller
    {
        private readonly ThElectroniX_DbContext _context;

        public HomeController(ThElectroniX_DbContext context)
        {
            _context = context;
        }

        // GET : products
        public IActionResult Index()
        {
           
            return View(_context.Categories.ToList());
        }
       



    }
}
