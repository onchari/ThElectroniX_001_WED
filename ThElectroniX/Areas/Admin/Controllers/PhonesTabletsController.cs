using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ThElectroniX_001_WED.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("admin/[controller]")]
    public class PhonesTabletsController : Controller
    {
        public IActionResult PhonesTablets()
        {
            return View();
        }
    }
}