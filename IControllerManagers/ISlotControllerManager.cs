using BusinessEntities.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IControllerManagers
{
    public interface ISlotControllerManager
    {
        slot GetSlot(int id);
        IEnumerable<slot> GetAllSlots();

        void AddSlot(slot entity);
        void AddMultipleSlots(IEnumerable<slot> entities);

        void UpdateSlot(int id, slot entity);

        void RemoveSlot(slot entity);
        void RemoveMultipleSlots(IEnumerable<slot> entities);

        bool SlotExists(int id);

        IEnumerable<slot> GetFreeSlots();
    }
}
