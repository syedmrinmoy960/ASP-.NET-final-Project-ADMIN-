using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interface
{
    public interface IRepo<T,ID>
    {
        void Add(T e);
        void Delete(ID id);
        void Edit(T e);
        List<T> GetAll();
        T Get(ID id);
    }
}
