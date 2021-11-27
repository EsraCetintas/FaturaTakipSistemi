using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
   public interface IFlatService
    {
        List<Flat> GetAll();
        Flat Get(int id);
        void Add(Flat flat);
        void Delete(Flat flat);
        void Update(Flat flat);
    }
}
