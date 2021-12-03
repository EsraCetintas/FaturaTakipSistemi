using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class DebtManager : IDebtService
    {
        IDebtDal _debtDal;

        public DebtManager(IDebtDal debtDal)
        {
            _debtDal = debtDal;
        }

        public void Add(Debt debt)
        {
            _debtDal.Add(debt);
        }

        public void Delete(Debt debt)
        {
            _debtDal.Delete(debt);
        }

        public Debt Get(int id)
        {
            return _debtDal.Get(d=>d.Id==id);
        }

        public List<Debt> GetAll()
        {
           return _debtDal.GetAll();
        }

        public void Update(Debt debt)
        {
            _debtDal.Update(debt);
        }
    }
}
