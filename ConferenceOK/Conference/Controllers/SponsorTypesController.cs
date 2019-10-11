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
            
        return View();
           
        }
    

        // GET: SponsorTypes/Edit/5
        public ActionResult Edit(int id)
        {
           
            return View();
        }

        // POST: SponsorTypes/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, SponsorTypesViewModel model)
        {
            
                return View();
            
        }

        // GET: SponsorTypes/Delete/5
        public ActionResult Delete(int id)
        {
            

            return View();
        }

        // POST: SponsorTypes/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, SponsorTypesViewModel model)
        {

            return View();
        }
    }
}