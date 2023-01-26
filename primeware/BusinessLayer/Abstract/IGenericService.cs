using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
   public interface IGenericService<T>
    {
        void Add(T t);
        void Delete(T product);
        void Update(T product);
        List<T> getList();
        T TgetByid(int id);
    }
}
