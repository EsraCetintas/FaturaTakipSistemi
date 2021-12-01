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
    public class EfFlatDal : IFlatDal
    {
        public void Add(Flat entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Flat entity)
        {
            throw new NotImplementedException();
        }

        public Flat Get(Expression<Func<Flat, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Flat> GetAll(Expression<Func<Flat, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Flat entity)
        {
            throw new NotImplementedException();
        }
    }
}
