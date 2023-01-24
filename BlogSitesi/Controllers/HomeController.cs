﻿using BlogSitesi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogSitesi.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        MVCBlogSitesiEntities DB = new MVCBlogSitesiEntities();
        public ActionResult Index()
        {
            return View(DB.Posts.ToList());
        }

    }
}
