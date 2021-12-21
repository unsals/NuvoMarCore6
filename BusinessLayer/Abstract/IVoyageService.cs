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
        void AddVoyage(Voyage voyage);
        void RemoveVoyage(Voyage voyage);
        void UpdateVoyage(Voyage voyage);
        Voyage GetById(int id);
        List<Voyage> GetAll();
        List<Voyage> GetAllWithPortAndShip();
    }
}
