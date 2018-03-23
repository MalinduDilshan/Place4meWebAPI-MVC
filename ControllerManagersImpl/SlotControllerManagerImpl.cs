using IControllerManagers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities.Database;
using IServices;
using ServicesImpl;

namespace ControllerManagersImpl
{
    public class SlotControllerManagerImpl : ISlotControllerManager
    {

        private AbstractSlotService _slotService;

        public SlotControllerManagerImpl()
        {
            _slotService = new SlotServiceImpl();
        }

        public void AddSlot(slot entity)    //implementation of AddSlot(slot entity) in ISlotControllerManager
        {
            try
            {
                _slotService.Add(entity);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void AddMultipleSlots(IEnumerable<slot> entities)    //implementation of AddMultipleSlots(IEnumerable<slot> entities) in ISlotControllerManager
        {
            try
            {
                _slotService.AddRange(entities);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void UpdateSlot(int id, slot entity) //implementation of UpdateSlot(int id, slot entity) in ISlotControllerManager
        {
            try
            {
                _slotService.Update(id, entity);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public slot GetSlot(int id) //implementation of GetSlot(int id) in ISlotControllerManager
        {
            try
            {
                return _slotService.Get(id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<slot> GetAllSlots()  //implementation of GetAllSlots() in ISlotControllerManager
        {
            try
            {
                return _slotService.GetAll();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void RemoveSlot(slot entity) //implementation of RemoveSlot(slot entity) in ISlotControllerManager
        {
            try
            {
                _slotService.Remove(entity);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void RemoveMultipleSlots(IEnumerable<slot> entities) //implementation of RemoveMultipleSlots(IEnumerable<slot> entities) in ISlotControllerManager
        {
            try
            {
                _slotService.RemoveRange(entities);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool SlotExists(int id)  //implementation of SlotExists(int id) in ISlotControllerManager
        {
            try
            {
                return _slotService.EntityExists(id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<slot> GetFreeSlots()
        {
            try
            {
                return _slotService.GetFreeSlots();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
