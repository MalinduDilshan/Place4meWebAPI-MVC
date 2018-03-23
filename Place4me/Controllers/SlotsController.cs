using System;
using System.Collections.Generic;
using BusinessEntities.Database;
using System.Web.Mvc;
using System.Net.Http;

namespace Place4me.Controllers
{
    public class SlotsController : Controller
    {
        [Authorize(Roles = "Admin,User")]
        // GET: Slots/5
        public ActionResult Index(int id)
        {
            try
            {
                HttpResponseMessage response = GlobalVariables.Place4meWebAPIClient.GetAsync("Slots/").Result;
                IEnumerable<slot> ListOfSlots = response.Content.ReadAsAsync<IEnumerable<slot>>().Result;

                List<slot> ListOfSlotForCarPark = new List<slot>();
                foreach(slot slot in ListOfSlots)
                {
                    if(slot.carpark_id == id)
                    {
                        ListOfSlotForCarPark.Add(slot);
                    }
                }
                return View(ListOfSlotForCarPark);
            }
            catch (Exception)
            {
                return View();
            }
        }

        [Authorize(Roles = "Admin")]
        // GET: Slots/Details/5
        public ActionResult Details(int id)
        {
            try
            {
                HttpResponseMessage response = GlobalVariables.Place4meWebAPIClient.GetAsync("Slots/" + id.ToString()).Result;
                return View(response.Content.ReadAsAsync<slot>().Result);
            }
            catch (Exception)
            {
                return View();
            }
        }

        [Authorize(Roles = "Admin")]
        // GET: Slots/Create
        public ActionResult Create(int id)
        {
            return View(new slot() { carpark_id = id});
        }

        [Authorize(Roles = "Admin")]
        // POST: Slots/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(slot entity)
        {
            try
            {
                HttpResponseMessage response = GlobalVariables.Place4meWebAPIClient.PostAsJsonAsync("Slots", entity).Result;
                TempData["SuccessMessage"] = "Saved Successfully";
                return RedirectToAction("Index","Carparks");
            }
            catch(Exception)
            {
                return View();
            }
        }

        [Authorize(Roles = "Admin")]
        // GET: Slots/Edit/5
        public ActionResult Edit(int id)
        {
            try
            {
                HttpResponseMessage response = GlobalVariables.Place4meWebAPIClient.GetAsync("Slots/" + id.ToString()).Result;
                return View(response.Content.ReadAsAsync<slot>().Result);
            }
            catch (Exception)
            {
                return View();
            }
        }

        [Authorize(Roles = "Admin")]
        // POST: Slots/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, slot entity)
        {
            try
            {
                HttpResponseMessage response = GlobalVariables.Place4meWebAPIClient.PutAsJsonAsync("Slots/"+ id, entity).Result;
                TempData["SuccessMessage"] = "Update Successfully";
                return RedirectToAction("Index", "Carparks");
            }
            catch
            {
                return View();
            }
        }

        [Authorize(Roles = "Admin")]
        // GET: Slots/Delete/5
        public ActionResult Delete(int id)
        {
            try
            {
                HttpResponseMessage response = GlobalVariables.Place4meWebAPIClient.DeleteAsync("Slots/" + id).Result;
                TempData["SuccessMessage"] = "Deleted Successfully";
                return RedirectToAction("Index", "Carparks");
            }
            catch (Exception)
            {
                return View();
            }
        }

        [Authorize(Roles = "Admin,User")]
        // GET: Slots/Map/5
        public ActionResult Map(int id)
        {
            try
            {
                HttpResponseMessage response = GlobalVariables.Place4meWebAPIClient.GetAsync("Slots/").Result;
                IEnumerable<slot> ListOfSlots = response.Content.ReadAsAsync<IEnumerable<slot>>().Result;

                List<slot> ListOfSlotForCarPark = new List<slot>();
                foreach (slot slot in ListOfSlots)
                {
                    if (slot.carpark_id == id)
                    {
                        ListOfSlotForCarPark.Add(slot);
                    }
                }
                return View(ListOfSlotForCarPark);
            }
            catch (Exception)
            {
                return View();
            }
        }
    }
}
