using BusinessEntities.Database;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IServices
{
    public abstract class AbstractSlotDetailService : IService<slot_details>
    {

        private Place4meEntities db;

        public AbstractSlotDetailService()
        {
            db = new Place4meEntities();
        }

        public void Add(slot_details entity)    //implementation of Add() in IService
        {
            try
            {
                entity.slot_details_status = 1;
                db.slot_details.Add(entity);
                db.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void AddRange(IEnumerable<slot_details> entities)        //implementation of AddRange() in IService
        {
            try
            {
                foreach(slot_details entity in entities)
                {
                    entity.slot_details_status = 1;
                }
                db.slot_details.AddRange(entities);
                db.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Update(int id, slot_details entity) //implementation of Update() in IService
        {
            try
            {
                var result = db.slot_details.Where(s => s.slot_details_id == id).FirstOrDefault();
                db.Entry(result).State = EntityState.Detached;
                db.Entry(entity).State = EntityState.Modified;
                db.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public slot_details Get(int id) //implementation of Get() in IService
        {
            try
            {
                List<slot_details> slotList = new List<slot_details>();
                slotList = db.slot_details.Where(s => s.slot_id == id && s.slot_details_status == 1).OrderByDescending(s => s.slot_details_id).ToList();
                return slotList.First();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<slot_details> GetAll()   //implementation of GetAll() in IService
        {
            try
            {
                return db.slot_details.Where(s => s.slot_details_status == 1).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Remove(slot_details entity) //implementation of Remove() in IService
        {
            try
            {
                var result = db.slot_details.Where(s => s.slot_details_id == entity.slot_details_id).FirstOrDefault();
                db.Entry(result).State = EntityState.Detached;
                entity.slot_details_status = 0;
                db.Entry(entity).State = EntityState.Modified;
                db.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void RemoveRange(IEnumerable<slot_details> entities) //implementation of RemoveRange() in IService
        {
            throw new NotImplementedException();
        }

        public bool EntityExists(int id)    //implementation of EntityExists() in IService
        {
            try
            {
                return db.slot_details.Count(s => s.slot_details_id == id) > 0;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
