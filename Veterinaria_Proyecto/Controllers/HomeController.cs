﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Veterinaria_Proyecto.Models;

namespace Veterinaria_Proyecto.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {

            return View();
        }

        public IActionResult LogIn()
        {
            return View();
        }
        public IActionResult LogOut()
        {
            return View();
        }
        public IActionResult AgregarMascota()
        {
            return View();
        }
        public IActionResult ActualizarProducto()
        {
            return View();
        }
        public IActionResult CrearProducto() {
            return View();
        }
        public IActionResult catFood() {
            return View();
        }
       

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
