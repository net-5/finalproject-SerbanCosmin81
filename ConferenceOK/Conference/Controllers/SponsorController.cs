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
        return View();
            
        }

        // GET: Sponsor/Edit/5
        public ActionResult Edit(int id)
        {
            
            return View();
        }

        // POST: Sponsor/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, SponsorViewModel model)
        {
        return View();
            
        }
        
        // GET: Sponsor/Delete/5
        public ActionResult Delete(int id)
        {
            

            return View();
        }

        // POST: Sponsor/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, SponsorViewModel model)
        {
            return View();
        }
    }
}