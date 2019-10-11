using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Conference.Models;
using Conference.Domain.Entities;
using Conference.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Omu.ValueInjecter;

namespace Conference.Controllers
{
    
    public class TalksController : Controller
    {

        private ITalksService talksService;

        public TalksController(ITalksService talksService)
        {
            this.talksService = talksService;
        }



        // GET: Talks
        public ActionResult Index()
        {
            var getAllTalks = talksService.GetAllTalks();
            return View(getAllTalks);
        }

        // GET: Talks/Details/5
        public ActionResult Details(int id)
        {
            var getTalkById = talksService.GetTalksById(id);
            TalksViewModel model = new TalksViewModel();
            model.InjectFrom(getTalkById);

            return View(model);
        }

        // GET: Talks/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Talks/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TalksViewModel model)
        {

         return View();
            
        }

        // GET: Talks/Edit/5
        public ActionResult Edit(int id)
        {
           
            return View();
        }

        // POST: Talks/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, TalksViewModel model)
        {

          return View();
            
        }

        // GET: Talks/Delete/5
        public ActionResult Delete(int id)
        {
           

            return View();
        }

        // POST: Talks/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, TalksViewModel model)
        {
            

            return View();
        }
    }
}