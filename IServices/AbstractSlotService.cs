using BusinessEntities.Database;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IServices
{
    public abstract class AbstractSlotService : IService<slot>
    {
        private Place4meEntities db;

        public AbstractSlotService()
        {
            db = new Place4meEntities();
        }

        public void Add(slot entity)    //implementation of Add() in IService
        {
            try
            {
                entity.slot_status = 1;
                db.slots.Add(entity);
                db.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void AddRange(IEnumerable<slot> entities)    //implementation of AddRange() in IService
        {
            try
            {
                foreach(slot entity in entities)
                {
                    entity.slot_status = 1;
                }
                db.slots.AddRange(entities);
                db.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Update(int id, slot entity) //implementation of Update() in IService
        {
            try
            {
                var result = db.slots.Where(s => s.slot_id == id).FirstOrDefault();
                db.Entry(result).State = EntityState.Detached;
                db.Entry(entity).State = EntityState.Modified;
                db.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public slot Get(int id) //implementation of Get() in IService
        {
            try
            {
                return db.slots.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<slot> GetAll()   //implementation of GetAll() in IService
        {
            try
            {
                return db.slots.Where(s => s.slot_status == 1).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Remove(slot entity) //implementation of Remove() in IService
        {
            try
            {
                var result = db.slots.Where(s => s.slot_id == entity.slot_id).FirstOrDefault();
                db.Entry(result).State = EntityState.Detached;
                entity.slot_status = 0;
                db.Entry(entity).State = EntityState.Modified;
                db.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void RemoveRange(IEnumerable<slot> entities) //implementation of RemoveRange() in IService
        {
            throw new NotImplementedException();
        }

        public bool EntityExists(int id)    //implementation of EntityExists() in IService
        {
            try
            {
                return db.slots.Count(s => s.slot_id == id) > 0;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public abstract IEnumerable<slot> GetFreeSlots(); //abstract GetFreeCarSlots() in this class
    }
}
