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
    public class SponsorController : Controller
    {

        private readonly ISponsorService sponsor;

        public SponsorController(ISponsorService sponsor)
        {
            this.sponsor = sponsor;
        }



        // GET: Sponsor
        public ActionResult Index()
        {
            var getAllSponsors = sponsor.GetSponsor();
            return View(getAllSponsors);
        }

        // GET: Sponsor/Details/5
        public ActionResult Details(int id)
        {
            var sponsorDetails = sponsor.GetById(id);
            SponsorViewModel model = new SponsorViewModel();
            model.InjectFrom(sponsorDetails);
            return View(model);
        }

        // GET: Sponsor/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Sponsor/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SponsorViewModel model)
        {
            if (ModelState.IsValid)
            {
                Sponsors sponsorToCreate = new Sponsors();

                sponsorToCreate.InjectFrom(model);

                var sponsorToAdd = sponsor.Create(sponsorToCreate);

                if (sponsorToAdd == null)
                {
                    ModelState.AddModelError("SponsorTypeId", "Sponsor Type Id must be unique");
                    return View(model);
                }

                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(model);
            }
        }

        // GET: Sponsor/Edit/5
        public ActionResult Edit(int id)
        {
            var getSponsorById = sponsor.GetById(id);
            SponsorViewModel sponsors = new SponsorViewModel();
            sponsors.InjectFrom(getSponsorById);

            return View(sponsors);
        }

        // POST: Sponsor/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, SponsorViewModel model)
        {
            if (ModelState.IsValid)
            {

                Sponsors sponsorsToCreate = new Sponsors();
                sponsorsToCreate.InjectFrom(model);
                sponsor.Update(sponsorsToCreate);

                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(model);
            }
        }
        // GET: Sponsor/Delete/5
        public ActionResult Delete(int id)
        {
            var deleteSponsor = sponsor.GetById(id);

            SponsorViewModel model = new SponsorViewModel();

            model.InjectFrom(deleteSponsor);

            return View(model);
        }

        // POST: Sponsor/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, SponsorViewModel model)
        {
            Sponsors deleteSponsor = new Sponsors();

            deleteSponsor = sponsor.GetById(id);

            model.InjectFrom(deleteSponsor);

            sponsor.DeleteSponsor(deleteSponsor);

            return RedirectToAction(nameof(Index));
        }
    }
}