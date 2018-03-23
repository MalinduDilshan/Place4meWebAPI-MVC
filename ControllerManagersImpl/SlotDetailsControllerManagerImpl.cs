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
    public class SlotDetailsControllerManagerImpl : ISlotDetailControllerManager
    {
        private AbstractSlotDetailService _slotDetailService;

        public SlotDetailsControllerManagerImpl()
        {
            _slotDetailService = new SlotDetailServiceImpl();
        }

        public void AddSlotDetail(slot_details entity)  //implementation of AddSlotDetail(slot_details entity) in ISlotDetailControllerManager
        {
            try
            {
                _slotDetailService.Add(entity);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void AddMultipleSlotDetails(IEnumerable<slot_details> entities)  //implementation of AddMultipleSlotDetails(IEnumerable<slot_details> entities) in ISlotDetailControllerManager
        {
            try
            {
                _slotDetailService.AddRange(entities);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void UpdateSlotDetail(int id, slot_details entity)   //implementation of UpdateSlotDetail(int id, slot_details entity) in ISlotDetailControllerManager
        {
            try
            {
                _slotDetailService.Update(id, entity);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public slot_details GetSlotDetail(int id)   //implementation of GetSlotDetail(int id) in ISlotDetailControllerManager
        {
            try
            {
                return _slotDetailService.Get(id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<slot_details> GetAllSlotDetails()    //implementation of GetAllSlotDetails() in ISlotDetailControllerManager
        {
            try
            {
                return _slotDetailService.GetAll();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void RemoveSlotDetail(slot_details entity)   //implementation of RemoveSlotDetail(slot_details entity) in ISlotDetailControllerManager
        {
            try
            {
                _slotDetailService.Remove(entity);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void RemoveMultipleSlotDetails(IEnumerable<slot_details> entities)   //implementation of RemoveMultipleSlotDetails(IEnumerable<slot_details> entities) in ISlotDetailControllerManager
        {
            try
            {
                _slotDetailService.RemoveRange(entities);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool SlotDetailExists(int id)    //implementation of SlotDetailExists(int id) in ISlotDetailControllerManager
        {
            try
            {
                return _slotDetailService.EntityExists(id);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
