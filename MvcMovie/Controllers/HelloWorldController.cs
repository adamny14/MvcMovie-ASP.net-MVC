﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        public string Index()
        {
            return "This  is my <b>Default</b> action...";
        }

        public string Welcome(string name, int numTimes=1)
        {
            return HttpUtility.HtmlEncode("Hello " + name + ", NumsTimes is: " + numTimes);
        }
    }
}