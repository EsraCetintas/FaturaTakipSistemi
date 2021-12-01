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
    public class EfDueDal : IDueDal
    {
        public void Add(Due entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Due entity)
        {
            throw new NotImplementedException();
        }

        public Due Get(Expression<Func<Due, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Due> GetAll(Expression<Func<Due, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Due entity)
        {
            throw new NotImplementedException();
        }
    }
}
