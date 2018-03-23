using BusinessEntities.Database;
using IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesImpl
{
    public class SlotServiceImpl : AbstractSlotService
    {
        //private Place4meEntities db;

        //public SlotServiceImpl()
        //{
        //    db = new Place4meEntities();
        //}

        public override IEnumerable<slot> GetFreeSlots()
        {
            throw new NotImplementedException();
        }
    }
}
