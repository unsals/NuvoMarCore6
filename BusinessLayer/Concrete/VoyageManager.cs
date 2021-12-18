using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class VoyageManager : IVoyageService
    {
        IVoyageDal _voyageDal;

        public VoyageManager(IVoyageDal voyageDal)
        {
            _voyageDal = voyageDal;
        }

        public void AddShip(Voyage voyage)
        {
            _voyageDal.Add(voyage);
        }

        public List<Voyage> GetAll()
        {
            return _voyageDal.GetAll();
        }

        public Voyage GetById(int id)
        {
            return _voyageDal.GetById(id);
        }

        public void RemoveShip(Voyage voyage)
        {
            _voyageDal.Remove(voyage);
        }

        public void UpdateShip(Voyage voyage)
        {
            _voyageDal.Update(voyage);
        }
    }
}
