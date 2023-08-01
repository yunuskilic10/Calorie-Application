using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    internal interface ICRUD<T> where T : class
    {
        public bool Add(T entity);
        public bool Update(T entity);
        public bool Remove(int id);
        public List<T> List();
        public T Find(int id);
    }
}
