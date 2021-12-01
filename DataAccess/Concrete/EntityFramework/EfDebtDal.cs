using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfDebtDal : IDebtDal
    {
        public void Add(Debt entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Debt entity)
        {
            throw new NotImplementedException();
        }

        public Debt Get(Expression<Func<Debt, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Debt> GetAll(Expression<Func<Debt, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Debt entity)
        {
            throw new NotImplementedException();
        }
    }
}
