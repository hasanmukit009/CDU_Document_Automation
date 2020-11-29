using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DMS.Web.Controllers
{
    public class UnitInfoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AddNewUnitInfo()
        {
            return View();
        }
    }
}