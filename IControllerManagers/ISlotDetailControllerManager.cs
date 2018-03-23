using BusinessEntities.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IControllerManagers
{
    public interface ISlotDetailControllerManager
    {
        slot_details GetSlotDetail(int id);
        IEnumerable<slot_details> GetAllSlotDetails();

        void AddSlotDetail(slot_details entity);
        void AddMultipleSlotDetails(IEnumerable<slot_details> entities);

        void UpdateSlotDetail(int id, slot_details entity);

        void RemoveSlotDetail(slot_details entity);
        void RemoveMultipleSlotDetails(IEnumerable<slot_details> entities);

        bool SlotDetailExists(int id);
    }
}
