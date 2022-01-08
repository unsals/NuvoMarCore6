using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;


namespace BusinessLayer.Concrete
{
    public class VoyageManager : IVoyageService
    {
        IVoyageDal _voyageDal;

        public VoyageManager(IVoyageDal voyageDal)
        {
            _voyageDal = voyageDal;
        }

        
        public void NAdd(Voyage t)
        {
            _voyageDal.Add(t);
        }

        public List<Voyage> NGetAll()
        {
            return _voyageDal.GetAll();
        }

        public Voyage NGetById(int id)
        {
            return _voyageDal.GetById(id);
        }

        public void NRemove(Voyage t)
        {
            _voyageDal.Remove(t);
        }

        public void NUpdate(Voyage t)
        {
            _voyageDal.Update(t);
        }

        public List<Voyage> GetAllWithPortAndShip()
        {
            return _voyageDal.GetListWithShipAndPort();
        }


        //Deneme yapmak için örnek olsun diye yazdım
        public List<Voyage> GetVoyageByID(int id)
        {
            return _voyageDal.GetAll(x => x.VoyageId == id);
        }
    }
}
