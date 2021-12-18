using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IShipService
    {
        void AddShip(Ship ship);
        void RemoveShip(Ship ship);
        void UpdateShip(Ship ship);
        Ship GetById(int id);
        List<Ship> GetAll();
    }
}
