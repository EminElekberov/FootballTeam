using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public interface IGenericService<T>
    {
        void TAdd(T t);
        void TDelete(T t);
        void TUpdate(T t);
        List<T> GetList();
        T GetById(Guid id);
    }
}
