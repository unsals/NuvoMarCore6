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
    public class VoyageRepository : IVoyageDal
    {

        Context c = new Context();

        public void AddShip(Voyage voyage)
        {
            c.Add(voyage);
            c.SaveChanges();
        }

        public void DeleteShip(Voyage voyage)
        {
            c.Remove(voyage);
            c.SaveChanges();
        }

        public Voyage GetById(int id)
        {
            return c.Voyages.Find(id);
        }

        public List<Voyage> ListAll()
        {
            return c.Voyages.ToList();
        }

        public void UpdateShip(Voyage voyage)
        {
            c.Update(voyage);
            c.SaveChanges();
        }
    }
}
