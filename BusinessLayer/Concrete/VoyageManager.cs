using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EF;
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

        public void AddVoyage(Voyage voyage)
        {
            _voyageDal.Add(voyage);
        }

        public List<Voyage> GetAll()
        {
            return _voyageDal.GetAll();
        }

        public List<Voyage> GetAllWithPortAndShip()
        {
            return _voyageDal.GetListWithShipAndPort();
        }

        public Voyage GetById(int id)
        {
            return _voyageDal.GetById(id);
        }

        //Deneme yapmak için örnek olsun diye yazdım
        public List<Voyage> GetVoyageByID(int id)
        {
            return _voyageDal.GetAll(x => x.VoyageId == id);
        }

        public void RemoveVoyage(Voyage voyage)
        {
            _voyageDal.Remove(voyage);
        }

        public void UpdateVoyage(Voyage voyage)
        {
            _voyageDal.Update(voyage);
        }
    }
}
