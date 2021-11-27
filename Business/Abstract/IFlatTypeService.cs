using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
  public  interface IFlatTypeService
    {
        List<FlatType> GetAll();
        FlatType Get(int id);
        void Add(FlatType flatType);
        void Delete(FlatType flatType);
        void Update(FlatType flatType);
    }
}
