﻿using System;
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
    public class EditionsController : Controller
    {

        private IEditionService editions;

        public EditionsController(IEditionService editionService)
        {
            this.editions = editionService;
        }


        // GET: Editions
        public ActionResult Index()
        {
            IEnumerable<Editions> allEditions = editions.GetEditions().OrderBy(x => x.Year);
            return View(allEditions);
        }

        // GET: Editions/Details/5
        public ActionResult Details(int id)
        {
            var getEditionById = editions.GetById(id);

            EditionViewModel model = new EditionViewModel();
            model.InjectFrom(getEditionById);

            return View(model);
        }

        // GET: Editions/Create
        public ActionResult Create()
        {
            //EditionViewModel model = new EditionViewModel();

            //var cr = editions.GetEditions();

            //ViewBag.Editions = cr;

            return View();
        }

        // POST: Editions/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EditionViewModel model)
        {

            if (ModelState.IsValid)
            {
                Editions editionToCreate = new Editions();

                editionToCreate.InjectFrom(model);

                var createNewEdition = editions.CreateEdition(editionToCreate);

                if (createNewEdition == null)
                {
                    ModelState.AddModelError("Name", "The Name must be unique!");

                    return View(model);
                }
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(model);
            }
        }

        // GET: Editions/Edit/5
        public ActionResult Edit(int id)
        {
            var editionToUpdate = editions.GetById(id);
            EditionViewModel model = new EditionViewModel();
            model.InjectFrom(editionToUpdate);

            return View(model);
        }

        // POST: Editions/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, EditionViewModel model)
        {


            if (ModelState.IsValid)
            {

                Editions editionToUpdate = new Editions();

                editionToUpdate.InjectFrom(model);

                var createNewEdition = editions.Update(editionToUpdate);

                if (createNewEdition == null)
                {
                    ModelState.AddModelError("Name", "The Name must be unique!");
                    return View(model);
                }

                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(model);
            }
        }

        // GET: Editions/Delete/5
        public ActionResult Delete(int id)
        {
            var editionToDelete = editions.GetById(id);

            EditionViewModel model = new EditionViewModel();

            model.InjectFrom(editionToDelete);

            return View(model);
        }

        // POST: Editions/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, EditionViewModel model)
        {

            Editions deleteEdition = new Editions();

            deleteEdition = editions.GetById(id);

            model.InjectFrom(deleteEdition);

            editions.DeleteEdition(deleteEdition);

            return RedirectToAction(nameof(Index));

        }
    }
}