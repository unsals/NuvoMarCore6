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
    public class ShipManager : IShipService
    {
        IShipDal _shipDal;

        public ShipManager(IShipDal shipDal)
        {
            _shipDal = shipDal;
        }

        public void NAdd(Ship t)
        {
            _shipDal.Add(t);
        }

        public List<Ship> NGetAll()
        {
            return _shipDal.GetAll();
        }

        public Ship NGetById(int id)
        {
            return _shipDal.GetById(id);
        }

        public void NRemove(Ship t)
        {
            throw new NotImplementedException();
        }

        public void NUpdate(Ship t)
        {
            _shipDal.Update(t);
        }

        public void RemoveShip(Ship ship)
        {
            _shipDal.Remove(ship);
        }
    }
}
