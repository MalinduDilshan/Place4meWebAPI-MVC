using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using BusinessEntities.Database;
using ControllerManagersImpl;
using IControllerManagers;

namespace Place4meWebAPI.Controllers
{
    public class SlotsController : ApiController
    {
        private ISlotControllerManager _slotControllerManager;
        private ISlotDetailControllerManager _slotDetailsControllerManager;

        public SlotsController()
        {
            _slotControllerManager = new SlotControllerManagerImpl();
            _slotDetailsControllerManager = new SlotDetailsControllerManagerImpl();
        }

        // GET: api/Slots
        public IEnumerable<slot> Getslots()
        {
            return _slotControllerManager.GetAllSlots();
        }

        // GET: api/Slots/5
        [ResponseType(typeof(slot))]
        public IHttpActionResult Getslot(int id)
        {
            slot slot = _slotControllerManager.GetSlot(id);
            if (slot == null)
            {
                return NotFound();
            }

            return Ok(slot);
        }

        // PUT: api/Slots/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Putslot(int id, slot slot)
        {
            if (id != slot.slot_id)
            {
                return BadRequest();
            }

            try
            {
                _slotControllerManager.UpdateSlot(id, slot);

                slot_details entity = new slot_details();

                if(slot.slot_isFree == 1)
                {
                    entity.slot_id = id;
                    entity.slot_details_parked_date = DateTime.Now.Date;
                    entity.slot_details_parked_time = DateTime.Now.ToString("HH:mm:ss");
                    _slotDetailsControllerManager.AddSlotDetail(entity);
                }
                else if(slot.slot_isFree == 0)
                {
                    slot_details existingEntity = _slotDetailsControllerManager.GetSlotDetail(id);
                    existingEntity.slot_details_parked_end_time = DateTime.Now.ToString("HH:mm:ss");
                    _slotDetailsControllerManager.UpdateSlotDetail(existingEntity.slot_details_id,existingEntity);
                }
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_slotControllerManager.SlotExists(id))
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

        // POST: api/Slots
        [ResponseType(typeof(slot))]
        public IHttpActionResult Postslot(slot slot)
        {
            _slotControllerManager.AddSlot(slot);

            return CreatedAtRoute("DefaultApi", new { id = slot.slot_id }, slot);
        }

        // DELETE: api/Slots/5
        [ResponseType(typeof(slot))]
        public IHttpActionResult Deleteslot(int id)
        {
            slot slot = _slotControllerManager.GetSlot(id);
            if (slot == null)
            {
                return NotFound();
            }

            _slotControllerManager.RemoveSlot(slot);

            return Ok(slot);
        }
    }
}