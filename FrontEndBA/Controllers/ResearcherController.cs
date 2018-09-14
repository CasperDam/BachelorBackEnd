﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FrontEndBA.Models.ResearcherModel.AccountViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FrontEndBA.Controllers
{
    public class ResearcherController : Controller
    {
        // GET: ResearcherLogin
        public ActionResult Index()
        {
            return View();
        }

        // GET: ResearcherLogin/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        public ActionResult LoginResearcher()
        {
            return View();
        }

        public ActionResult RegisterResearcher()
        {
            return View();
        }

        // POST: ParticipantLogin/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult RegisterResearcher([Bind("Email,Firstname,Lastname,Password")] ResearcherRegisterViewModel researcherRegisterobj)
        {

            var test = researcherRegisterobj;


            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }




    }
}