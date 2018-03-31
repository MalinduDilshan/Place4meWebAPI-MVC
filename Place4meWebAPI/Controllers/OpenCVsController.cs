using BusinessEntities.Database;
using ControllerManagersImpl;
using IControllerManagers;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace Place4meWebAPI.Controllers
{
    public class OpenCVsController : ApiController
    {
        private ISlotControllerManager _slotControllerManager;
        private ISlotDetailControllerManager _slotDetailsControllerManager;

        public OpenCVsController()
        {
            _slotControllerManager = new SlotControllerManagerImpl();
            _slotDetailsControllerManager = new SlotDetailsControllerManagerImpl();
        }
        // POST: api/OpenCVsController
        [ResponseType(typeof(slot))]
        public IHttpActionResult Postslot(slot slot)
        {
            try
            {
                _slotControllerManager.UpdateSlot(slot.slot_id, slot);

                slot_details entity = new slot_details();

                if (slot.slot_isFree == 1)
                {
                    entity.slot_id = slot.slot_id;
                    entity.slot_details_parked_date = DateTime.Now.Date;
                    entity.slot_details_parked_time = DateTime.Now.ToString("HH:mm:ss");
                    _slotDetailsControllerManager.AddSlotDetail(entity);
                }
                else if (slot.slot_isFree == 0)
                {
                    slot_details existingEntity = _slotDetailsControllerManager.GetSlotDetail(slot.slot_id);
                    existingEntity.slot_details_parked_end_time = DateTime.Now.ToString("HH:mm:ss");
                    _slotDetailsControllerManager.UpdateSlotDetail(existingEntity.slot_details_id, existingEntity);
                }
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_slotControllerManager.SlotExists(slot.slot_id))
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
    }
}
