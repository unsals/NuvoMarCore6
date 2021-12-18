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
    public class ShipManager : IShipService
    {
        IShipDal _shipDal;

        public ShipManager(IShipDal shipDal)
        {
            _shipDal = shipDal;
        }

        public void AddShip(Ship ship)
        {
            _shipDal.Add(ship);
        }

        public List<Ship> GetAll()
        {
            return _shipDal.GetAll();
        }

        public Ship GetById(int id)
        {
            return _shipDal.GetById(id);
        }

        public void RemoveShip(Ship ship)
        {
            _shipDal.Remove(ship);
        }

        public void UpdateShip(Ship ship)
        {
            _shipDal.Update(ship);
        }
    }
}
