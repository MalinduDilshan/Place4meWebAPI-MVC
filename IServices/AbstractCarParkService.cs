using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities.Database;
using Place4meModels;

namespace IServices
{
    public abstract class AbstractCarParkService : IService<carpark>
    {
        private Place4meEntities db;

        public AbstractCarParkService()
        {
            db = new Place4meEntities();
        }

        public void Add(carpark entity)  //implementation of Add() in IService
        {
            try
            {
                entity.carpark_status = 1;
                db.carparks.Add(entity);
                db.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void AddRange(IEnumerable<carpark> entities)  //implementation of AddRange() in IService
        {
            try
            {
                foreach(carpark entity in entities)
                {
                    entity.carpark_status = 1;
                }
                db.carparks.AddRange(entities);
                db.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Update(int id, carpark entity)  //implementation of Update() in IService
        {
            try
            {
                var result = db.carparks.Where(c => c.carpark_id == id).FirstOrDefault();
                db.Entry(result).State = EntityState.Detached;
                db.Entry(entity).State = EntityState.Modified;
                db.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public carpark Get(int id)  //implementation of Get() in IService
        {
            try
            {
                return db.carparks.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<carpark> GetAll()    //implementation of GetAll() in IService
        {
            try
            {
                return db.carparks.Where(c => c.carpark_status == 1).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Remove(carpark entity)   //implementation of Remove() in IService
        {
            try
            {
                var result = db.carparks.Where(c => c.carpark_id == entity.carpark_id).FirstOrDefault();
                db.Entry(result).State = EntityState.Detached;
                entity.carpark_status = 0;
                db.Entry(entity).State = EntityState.Modified;
                db.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void RemoveRange(IEnumerable<carpark> entities)   //implementation of RemoveRange() in IService
        {
            throw new NotImplementedException();
        }

        public bool EntityExists(int id)     //implementation of EntityExists() in IService
        {
            try
            {
                return db.carparks.Count(c => c.carpark_id == id) > 0;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public abstract IEnumerable<carpark> GetFreeCarParks(); //abstract GetFreeCarParks() in this class

        public abstract IEnumerable<CarparkForMobile> GetCarParksForMobile();   //abstract GetCarParksForMobile() in this class

        public abstract CarParkFreeSlotNo GetCarParksFreeSlotNo(int carparkid);   //abstract GetCarParksFreeSlotNo() in this class
    }
}
