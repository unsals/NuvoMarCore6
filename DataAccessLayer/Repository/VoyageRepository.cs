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

        public void Add(Voyage entity)
        {
            c.Add(entity);
            c.SaveChanges();
        }

        public void Delete(Voyage entity)
        {
            c.Remove(entity);
            c.SaveChanges();
        }

        public List<Voyage> GetAll()
        {
            return c.Voyages.ToList();
        }

        public Voyage GetById(int id)
        {
            return c.Voyages.Find(id);
        }

        public void Update(Voyage entity)
        {
            c.Update(entity);
            c.SaveChanges();
        }
    }
}
