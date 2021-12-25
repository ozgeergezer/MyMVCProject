using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IRepository<T> //crud yapacağız burada
    {
        List<T> List();
        void Insert(T p);
        void Update(T p);
        void Delete(T p);
    }
}
