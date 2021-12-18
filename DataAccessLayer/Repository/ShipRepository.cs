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

        public void AddShip(Ship ship)
        {
            c.Add(ship);
            c.SaveChanges();
        }

        public void DeleteShip(Ship ship)
        {
            c.Remove(ship);
            c.SaveChanges();
        }

        public Ship GetById(int id)
        {
            return c.Ships.Find(id);
        }

        public List<Ship> ListAll()
        {
            return c.Ships.ToList();
        }

        public void UpdateShip(Ship ship)
        {
            c.Update(ship);
            c.SaveChanges();
        }
    }
}
