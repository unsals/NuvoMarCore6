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
    public class PortManager : IPortService
    {
        IPortDal _portDal;

        public PortManager(IPortDal portDal)
        {
            _portDal = portDal;
        }

        public void NAdd(Port t)
        {
            _portDal.Add(t);
        }

        public List<Port> NGetAll()
        {
            return _portDal.GetAll();
        }

        public Port NGetById(int id)
        {
            return _portDal.GetById(id);
        }

        public void NRemove(Port t)
        {
            _portDal.Remove(t);
        }

        public void NUpdate(Port t)
        {
            _portDal.Update(t);
        }
    }
}
