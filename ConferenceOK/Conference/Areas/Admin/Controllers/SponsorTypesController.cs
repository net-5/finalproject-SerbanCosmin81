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
{   [Area("Admin")]
    public class SponsorTypesController : Controller
    {
        private readonly ISponsorTypesService sponsor;

        public SponsorTypesController(ISponsorTypesService sponsor)
        {
            this.sponsor = sponsor;
        }



        // GET: SponsorTypes
        public ActionResult Index()
        {
            var getAllSponsorTypes = sponsor.GetSponsorTypes();
            return View(getAllSponsorTypes);
        }

        // GET: SponsorTypes/Details/5
        public ActionResult Details(int id)
        {
            var sponsorTypeDetails = sponsor.GetById(id);
            SponsorTypesViewModel model = new SponsorTypesViewModel();
            model.InjectFrom(sponsorTypeDetails);
            return View(model);
        }

        // GET: SponsorTypes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SponsorTypes/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SponsorTypesViewModel model)
        {

            if (ModelState.IsValid)
            {
                SponsorTypes sponsors = new SponsorTypes();

                sponsors.InjectFrom(model);

                var sponsorToCreate = sponsor.Create(sponsors);
                
                  return RedirectToAction(nameof(Index));
                
            }
            else
            {
                return View(model);
            }

        }
    

        // GET: SponsorTypes/Edit/5
        public ActionResult Edit(int id)
        {
            var getSponsorTypesById = sponsor.GetById(id);
            SponsorTypesViewModel sponsorTypes = new SponsorTypesViewModel();
            sponsorTypes.InjectFrom(getSponsorTypesById);

            return View(sponsorTypes);
        }

        // POST: SponsorTypes/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, SponsorTypesViewModel model)
        {
            if (ModelState.IsValid)
            {
                SponsorTypes sponsorTypes = new SponsorTypes();
                sponsorTypes.InjectFrom(model);
                sponsor.Update(sponsorTypes);

                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(model);
            }
        }

        // GET: SponsorTypes/Delete/5
        public ActionResult Delete(int id)
        {
            var deleteSponsorTypes = sponsor.GetById(id);

            SponsorTypesViewModel model = new SponsorTypesViewModel();

            model.InjectFrom(deleteSponsorTypes);

            return View(model);
        }

        // POST: SponsorTypes/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, SponsorTypesViewModel model)
        {
            SponsorTypes deleteSponsorTypes = new SponsorTypes();

            deleteSponsorTypes = sponsor.GetById(id);

            model.InjectFrom(deleteSponsorTypes);

            sponsor.DeleteSponsorTypes(deleteSponsorTypes);

            return RedirectToAction(nameof(Index));
        }
    }
}