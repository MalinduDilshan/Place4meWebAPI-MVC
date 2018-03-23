using System;
using System.Collections.Generic;
using BusinessEntities.Database;
using System.Web.Mvc;
using System.Net.Http;

namespace Place4me.Controllers
{
    public class CarParksController : Controller
    {
        [Authorize(Roles ="Admin,User")]
        // GET: CarParks
        public ActionResult Index()
        {
            try
            {
                HttpResponseMessage response = GlobalVariables.Place4meWebAPIClient.GetAsync("CarParks").Result;
                return View(response.Content.ReadAsAsync<IEnumerable<carpark>>().Result);
            }
            catch (Exception)
            {
                return View();
            }
        }

        [Authorize(Roles = "Admin")]
        // GET: CarParks/Details/5
        public ActionResult Details(int id)
        {
            try
            {
                HttpResponseMessage response = GlobalVariables.Place4meWebAPIClient.GetAsync("CarParks/" + id.ToString()).Result;
                return View(response.Content.ReadAsAsync<carpark>().Result);
            }
            catch (Exception)
            {
                return View();
            }
        }

        [Authorize(Roles = "Admin")]
        // GET: CarParks/Create
        public ActionResult Create()
        {
            return View();
        }

        [Authorize(Roles = "Admin")]
        // POST: CarParks/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(carpark entity)
        {
            try
            {
                HttpResponseMessage response = GlobalVariables.Place4meWebAPIClient.PostAsJsonAsync("CarParks", entity).Result;
                TempData["SuccessMessage"] = "Saved Successfully";
                return RedirectToAction("Index");
            }
            catch(Exception)
            {
                return View();
            }
        }

        [Authorize(Roles = "Admin")]
        // GET: CarParks/Edit/5
        public ActionResult Edit(int id)
        {
            try
            {
                HttpResponseMessage response = GlobalVariables.Place4meWebAPIClient.GetAsync("CarParks/" + id.ToString()).Result;
                return View(response.Content.ReadAsAsync<carpark>().Result);
            }
            catch (Exception)
            {
                return View();
            }
        }

        [Authorize(Roles = "Admin")]
        // POST: CarParks/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, carpark entity)
        {
            try
            {
                HttpResponseMessage response = GlobalVariables.Place4meWebAPIClient.PutAsJsonAsync("CarParks/"+ id, entity).Result;
                TempData["SuccessMessage"] = "Update Successfully";
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        [Authorize(Roles = "Admin")]
        // GET: CarParks/Delete/5
        public ActionResult Delete(int id)
        {
            try
            {
                HttpResponseMessage response = GlobalVariables.Place4meWebAPIClient.DeleteAsync("CarParks/" + id).Result;
                TempData["SuccessMessage"] = "Deleted Successfully";
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                return View();
            }
        }

        // GET: CarParks/Map/5
        public ActionResult Map(int id)
        {
            try
            {
                HttpResponseMessage response = GlobalVariables.Place4meWebAPIClient.GetAsync("CarParks/" + id.ToString()).Result;
                return View(response.Content.ReadAsAsync<carpark>().Result);
            }
            catch (Exception)
            {
                return View();
            }
        }
    }
}
