﻿using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using new_1.Models;
using new_1.Models.Repositery;

namespace new_1.Controllers
{
    public class ArtistController : Controller
    {

        ArtistRepositery repositery = new ArtistRepositery();



        public ActionResult Details(int id)
        {
            Artist artist = repositery.Get(id);
            if (artist == null)
            {
                return HttpNotFound();

            }
            else
            {
                return View(artist);
            }

        }





        // GET: Artist
        public ActionResult Index()
        {
            return View(repositery.GetAll());
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Edit(int id)
        {

            Artist artist = repositery.Get(id);
            if (artist == null)
            {
                return HttpNotFound();

            }
            else
            {
                return View(artist);
            }


        }


        [HttpPost()]
        public ActionResult Edit(Artist artist)
        {

            if (!ModelState.IsValid)
            {
                return View(artist);
            }


            repositery.Update(artist);
            repositery.SaveChanges();
            return RedirectToAction("Create");


        }




        [HttpPost()]
        public ActionResult Create(Artist artist)
        {

            if (!ModelState.IsValid)
            {
                return View(artist);
            }


            repositery.Add(artist);
            repositery.SaveChanges();
            return RedirectToAction("Create");


        }

        protected override void Dispose(bool disposing)
        {
            repositery.Dispose();
            base.Dispose(disposing);
        }
    }
}