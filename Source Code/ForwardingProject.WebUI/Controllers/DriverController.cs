using System.Collections.Generic;
using System.Web.Mvc;
using ForwardingProject.Domain.Entities;
using System.Linq;
using ForwardingProject.Domain.Abstract;

namespace ForwardingProject.WebUI.Controllers
{
    public class DriverController : Controller
    { 
        private readonly IDriverRepository repository;


        public DriverController(IDriverRepository driverrepository)
        {
            repository = driverrepository;
        }


        // GET: Driver
        public ActionResult Index()
        { 
            IEnumerable<Driver> drivers = repository.Collection;
            return View(drivers);
        }

        [HttpGet]
        [ActionName("Create")]
        public ActionResult Create_Get()
        {
            return View();
        }

        [HttpPost]
        [ActionName("Create")]
        public ActionResult Create_Post()
        {

            Driver driver = new Driver();
            TryUpdateModel<Driver>(driver);

            if (ModelState.IsValid)
            {
                repository.Add(driver);
                return RedirectToAction("Index");
            }
            return View();
        }


        [HttpGet]
        public ActionResult Edit(int id)
        {
           Driver driver = repository.Collection.Single(dr => dr.ID == id);
            return View(driver);
        }

        [HttpPost]
        public ActionResult Edit(Driver driver)
        {

            if (ModelState.IsValid)
            {
                repository.Edit(driver);
                return RedirectToAction("Index");
            }
            
            return View(driver);
        }
        [HttpPost]
        public ActionResult Delete(int id)
        {
            repository.Delete(id);
            return RedirectToAction("Index");
        } 
    }
}