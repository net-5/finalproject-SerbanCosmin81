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
    public class WorkshopController : Controller
    {


        private readonly IWorkShopService workShopService;
        private readonly ISpeakerService speakerService;

        public WorkshopController(IWorkShopService workShopService,ISpeakerService speakerService)
        {
            this.workShopService = workShopService;
            this.speakerService = speakerService;
        }
        
        // GET: Workshop
        public ActionResult Index()
        {
            var getAllWorkshops = workShopService.GetAllWorkshops();
            return View(getAllWorkshops);
        }

        // GET: Workshop/Details/5
        public ActionResult Details(int id)
        {
            var getWorkshopById = workShopService.GetWorkshopsById(id);
            WorkshopViewModel model = new WorkshopViewModel();
            model.InjectFrom(getWorkshopById);

            return View(model);
        }

        // GET: Workshop/Create
        public ActionResult Create()
        {
            

            return View();
        }

        // POST: Workshop/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(WorkshopViewModel model)
        {
            
                if (ModelState.IsValid)
                {
                    Workshops workshop = new Workshops();
                    workshop.InjectFrom(model);
                    var addedWorkshop = workShopService.CreateAWorkshop(workshop);

                    if (addedWorkshop == null)
                    {
                        ModelState.AddModelError("Name", "The Name must be unique");
                        return View(model);
                    }
                

                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(model);
            }
        }

        // GET: Workshop/Edit/5
        public ActionResult Edit(int id)
        {
            var getWorkshopById = workShopService.GetWorkshopsById(id);
            WorkshopViewModel model = new WorkshopViewModel();
            model.InjectFrom(getWorkshopById);

            return View(model);
        }

        // POST: Workshop/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, WorkshopViewModel model)
        {
            if (ModelState.IsValid)
            {

                Workshops workshops = new Workshops();
                workshops.InjectFrom(model);
                var updateWorkshop=workShopService.UpdateAWorkshop(workshops);

                if (updateWorkshop == null)
                {
                    ModelState.AddModelError("Name", "The Name must be unique");
                    return View(model);
                }

                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(model);
            }

        }

            // GET: Workshop/Delete/5
            public ActionResult Delete(int id)
        {
            var deleteWorkshop = workShopService.GetWorkshopsById(id);

            WorkshopViewModel model = new WorkshopViewModel();

            model.InjectFrom(deleteWorkshop);

            return View(model);
        }

        // POST: Workshop/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, WorkshopViewModel model)
        {

            Workshops deleteWorkshop = new Workshops();

            deleteWorkshop = workShopService.GetWorkshopsById(id);

            model.InjectFrom(deleteWorkshop);

            workShopService.DeleteAWorkshop(deleteWorkshop);

            return RedirectToAction(nameof(Index));
        }
    }
}