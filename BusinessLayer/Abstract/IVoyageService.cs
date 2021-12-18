using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IVoyageService
    {
        void AddShip(Voyage voyage);
        void RemoveShip(Voyage voyage);
        void UpdateShip(Voyage voyage);
        Voyage GetById(int id);
        List<Voyage> GetAll();
    }
}
