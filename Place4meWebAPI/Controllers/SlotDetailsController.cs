using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using BusinessEntities.Database;
using IControllerManagers;
using ControllerManagersImpl;

namespace Place4meWebAPI.Controllers
{
    public class SlotDetailsController : ApiController
    {
        private ISlotDetailControllerManager _slotDetailControllerManager;

        public SlotDetailsController()
        {
            _slotDetailControllerManager = new SlotDetailsControllerManagerImpl();
        }

        // GET: api/SlotDetails
        public IEnumerable<slot_details> Getslot_details()
        {
            return _slotDetailControllerManager.GetAllSlotDetails();
        }

        // GET: api/SlotDetails/5
        [ResponseType(typeof(slot_details))]
        public IHttpActionResult Getslot_details(int id)
        {
            slot_details slot_details = _slotDetailControllerManager.GetSlotDetail(id);
            if (slot_details == null)
            {
                return NotFound();
            }

            return Ok(slot_details);
        }

        // PUT: api/SlotDetails/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Putslot_details(int id, slot_details slot_details)
        {
            if (id != slot_details.slot_details_id)
            {
                return BadRequest();
            }

            try
            {
                _slotDetailControllerManager.UpdateSlotDetail(id, slot_details);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_slotDetailControllerManager.SlotDetailExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            catch (Exception)
            {
                throw;
            }
            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/SlotDetails
        [ResponseType(typeof(slot_details))]
        public IHttpActionResult Postslot_details(slot_details slot_details)
        {
            _slotDetailControllerManager.AddSlotDetail(slot_details);

            return CreatedAtRoute("DefaultApi", new { id = slot_details.slot_details_id }, slot_details);
        }

        // DELETE: api/SlotDetails/5
        [ResponseType(typeof(slot_details))]
        public IHttpActionResult Deleteslot_details(int id)
        {
            slot_details slot_details = _slotDetailControllerManager.GetSlotDetail(id);
            if (slot_details == null)
            {
                return NotFound();
            }

            _slotDetailControllerManager.RemoveSlotDetail(slot_details);

            return Ok(slot_details);
        }
    }
}