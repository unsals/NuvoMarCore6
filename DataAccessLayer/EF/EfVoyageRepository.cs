using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EF
{
    public class EfVoyageRepository : GenericRepository<Voyage>, IVoyageDal
    {
        public List<Voyage> GetListWithShipAndPort()
        {
            using (var c = new Context())
            {
                return c.Voyages.Include(x => x.Port).Include(x => x.Ship).ToList();
            }
        }
    }
}
