using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IDAL<T>
    {
        void Add(T item);
        void Update(T item);
        void Delete(T item);
        void Get(T item);
    }
}
