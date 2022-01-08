using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IGenericService<T>
    {
        void NAdd(T t);
        void NRemove(T t);
        void NUpdate(T t);
        T NGetById(int id);
        List<T> NGetAll();
    }
}
