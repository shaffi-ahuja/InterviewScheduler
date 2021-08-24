using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntschSH.Controllers
{
    public class CandidateController : Controller
    {
        public IActionResult UpsertProfile()
        {
            return View();
        }
        public IActionResult MyProfile()
        {
            return View();
        }
    }
}
