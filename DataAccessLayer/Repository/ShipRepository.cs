using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;   

namespace DataAccessLayer.Repository
{
    public class ShipRepository : IShipDal
    {

        Context c = new Context();

        public void Add(Ship entity)
        {
            c.Add(entity);
            c.SaveChanges();
        }

        public void Remove(Ship entity)
        {
            c.Remove(entity);
            c.SaveChanges();
        }

        public List<Ship> GetAll()
        {
            return c.Ships.ToList();
        }

        public Ship GetById(int id)
        {
            return c.Ships.Find(id);
        }

        public void Update(Ship entity)
        {
            c.Update(entity);
            c.SaveChanges();
        }
    }
}
