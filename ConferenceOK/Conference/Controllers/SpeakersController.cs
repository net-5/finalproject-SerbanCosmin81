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

    
    public class SpeakersController : Controller
    {

        private readonly ISpeakerService speakerService;
       

        public SpeakersController(ISpeakerService speakerService)
        {
            this.speakerService = speakerService;
            
        }


        // GET: Speakers
        public ActionResult Index()
        {
            var getAllSpeakers = speakerService.GetSpeakers();
            return View(getAllSpeakers);
        }

        // GET: Speakers/Details/5
        public ActionResult Details(int id)
        {
            var speakerDetails = speakerService.GetById(id);
            SpeakersViewModel model = new SpeakersViewModel();
            model.InjectFrom(speakerDetails);
            return View(model);


        }

        // GET: Speakers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Speakers/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SpeakersViewModel speakers)
        {
            
               
         return View();
            
        }
           


        // GET: Speakers/Edit/5
        public ActionResult Edit(int id)
        {
            
            return View();
        }

        // POST: Speakers/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, SpeakersViewModel model)
        {
           
           return View();
            
        }

        // GET: Speakers/Delete/5
        public ActionResult Delete(int id)
        {
           
            return View();
        }

        // POST: Speakers/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, SpeakersViewModel model)
        {

            return View();
        }
    }
}
