using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DB<T> : IDAL<T>
    {
        public void Add(T item)
        {

        }

        public void Delete(T item)
        {
            throw new NotImplementedException();
        }

        public void Get(T item)
        {
            throw new NotImplementedException();
        }

        public void Update(T item)
        {
            throw new NotImplementedException();
        }
    }
}
