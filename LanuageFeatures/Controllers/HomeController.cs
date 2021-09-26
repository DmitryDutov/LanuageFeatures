using LanuageFeatures.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace LanuageFeatures.Controllers
{
    //Создание общего шаблона действия
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View(Product.GetProduct().Select(p => p?.Name));
        }
    }
}
