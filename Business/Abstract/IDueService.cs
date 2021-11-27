using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
   public interface IDueService
    {
        List<Due> GetAll();
        Due Get(int id);
        void Add(Due due);
        void Delete(Due due);
        void Update(Due due);
    }
}
