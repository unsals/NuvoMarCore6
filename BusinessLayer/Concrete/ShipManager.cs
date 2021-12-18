using BusinessLayer.Abstract;
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
        EfShipRepository efShipRepository;

        public ShipManager()
        {
            efShipRepository = new EfShipRepository();
        }

        public void AddShip(Ship ship)
        {
            throw new NotImplementedException();
        }

        public List<Ship> GetAll()
        {
            throw new NotImplementedException();
        }

        public Ship GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void RemoveShip(Ship ship)
        {
            throw new NotImplementedException();
        }

        public void UpdateShip(Ship ship)
        {
            throw new NotImplementedException();
        }
    }
}
