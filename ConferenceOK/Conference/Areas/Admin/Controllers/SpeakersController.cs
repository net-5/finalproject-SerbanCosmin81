using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Conference.Areas.Admin.Models;
using Conference.Domain.Entities;
using Conference.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Omu.ValueInjecter;

namespace Conference.Areas.Admin.Controllers
{

    [Area("Admin")]
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
            
                if (ModelState.IsValid)
                {

                    Speakers speakerToAdd = new Speakers();
                    speakerToAdd.InjectFrom(speakers);
                    speakerService.Create(speakerToAdd);
                   
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(speakers);
            }
        }
           


        // GET: Speakers/Edit/5
        public ActionResult Edit(int id)
        {
            var editSpeaker = speakerService.GetById(id);
            SpeakersViewModel model = new SpeakersViewModel();
            model.InjectFrom(editSpeaker);

            return View(model);
        }

        // POST: Speakers/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, SpeakersViewModel model)
        {
            if (ModelState.IsValid)
            {
                Speakers speakersToUpdate = new Speakers();
                speakersToUpdate.InjectFrom(model);
                speakerService.Update(speakersToUpdate);

                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(model);
            }
        }

        // GET: Speakers/Delete/5
        public ActionResult Delete(int id)
        {
            var speakerToDelete = speakerService.GetById(id);

            SpeakersViewModel model = new SpeakersViewModel();

            model.InjectFrom(speakerToDelete);

            return View(model);
        }

        // POST: Speakers/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, SpeakersViewModel model)
        {

            Speakers deleteSpeaker = new Speakers();

            deleteSpeaker = speakerService.GetById(id);

            model.InjectFrom(deleteSpeaker);

            speakerService.DeleteSpeaker(deleteSpeaker);

            return RedirectToAction(nameof(Index));
        }
    }
}
