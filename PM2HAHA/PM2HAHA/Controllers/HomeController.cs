﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PM2HAHA.Models;
using Microsoft.EntityFrameworkCore;
using System.Net;
using Newtonsoft.Json;


namespace PM2HAHA.Controllers
{
    [Route("Home")]
    public class HomeController : Controller
    {
        private test_dbContext db;
        public HomeController(test_dbContext ctx)
        {
            db = ctx;
        }


        [Route("")]      // Combines to define the route template "Home"
        [Route("Index")] // Combines to define the route template "Home/Index"
        [Route("/")]     // Doesn't combine, defines the route template ""
        public IActionResult Index()
        {
           
            return View();
        }

        [HttpPost]
        public ActionResult Create(MstUsers std)
        {
            //write code to update student 
            var gg=std;
            return RedirectToAction("About");
        }

        [Route("About")] // Combines to define the route template "Home/About"
        public IActionResult Privacy()
        {
            return View();
        }
    }
}
