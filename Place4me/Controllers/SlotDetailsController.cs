using System;
using System.Collections.Generic;
using BusinessEntities.Database;
using System.Web.Mvc;
using System.Net.Http;

namespace Place4me.Controllers
{
    public class SlotDetailsController : Controller
    {
        [Authorize(Roles = "Admin")]
        // GET: SlotDetails
        public ActionResult Index(int id)
        {
            try
            {
                HttpResponseMessage response = GlobalVariables.Place4meWebAPIClient.GetAsync("SlotDetails/").Result;
                IEnumerable<slot_details> ListOfSlotsDetails = response.Content.ReadAsAsync<IEnumerable<slot_details>>().Result;

                List<slot_details> ListOfSlotDetailsForSlot = new List<slot_details>();
                foreach (slot_details slotDetails in ListOfSlotsDetails)
                {
                    if (slotDetails.slot_id == id)
                    {
                        ListOfSlotDetailsForSlot.Add(slotDetails);
                    }
                }
                return View(ListOfSlotDetailsForSlot);
            }
            catch (Exception)
            {
                return View();
            }
        }

        [Authorize(Roles = "Admin")]
        // GET: SlotDetails/Details/5
        public ActionResult Details(int id)
        {
            try
            {
                HttpResponseMessage response = GlobalVariables.Place4meWebAPIClient.GetAsync("SlotDetails/" + id.ToString()).Result;
                return View(response.Content.ReadAsAsync<slot_details>().Result);
            }
            catch (Exception)
            {
                return View();
            }
        }

        [Authorize(Roles = "Admin")]
        // GET: SlotDetails/Create
        public ActionResult Create()
        {
            return View();
        }

        [Authorize(Roles = "Admin")]
        // POST: SlotDetails/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(slot_details entity)
        {
            try
            {
                HttpResponseMessage response = GlobalVariables.Place4meWebAPIClient.PostAsJsonAsync("SlotDetails", entity).Result;
                TempData["SuccessMessage"] = "Saved Successfully";
                return RedirectToAction("Index", "Carparks");
            }
            catch(Exception)
            {
                return View();
            }
        }

        [Authorize(Roles = "Admin")]
        // GET: SlotDetails/Edit/5
        public ActionResult Edit(int id)
        {
            try
            {
                HttpResponseMessage response = GlobalVariables.Place4meWebAPIClient.GetAsync("SlotDetails/" + id.ToString()).Result;
                return View(response.Content.ReadAsAsync<slot_details>().Result);
            }
            catch (Exception)
            {
                return View();
            }
        }

        [Authorize(Roles = "Admin")]
        // POST: SlotDetails/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, slot_details entity)
        {
            try
            {
                HttpResponseMessage response = GlobalVariables.Place4meWebAPIClient.PutAsJsonAsync("SlotDetails/"+ id, entity).Result;
                TempData["SuccessMessage"] = "Update Successfully";
                return RedirectToAction("Index", "Carparks");
            }
            catch
            {
                return View();
            }
        }

        [Authorize(Roles = "Admin")]
        // GET: SlotDetails/Delete/5
        public ActionResult Delete(int id)
        {
            try
            {
                HttpResponseMessage response = GlobalVariables.Place4meWebAPIClient.DeleteAsync("SlotDetails/" + id).Result;
                TempData["SuccessMessage"] = "Deleted Successfully";
                return RedirectToAction("Index", "Carparks");
            }
            catch (Exception)
            {
                return View();
            }
        }
    }
}
