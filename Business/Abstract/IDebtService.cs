using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
   public interface IDebtService
    {
        List<Debt> GetAll();
        Debt Get(int id);
        void Add(Debt debt);
        void Delete(Debt debt);
        void Update(Debt debt);
    }
}
