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
    public class EfFlatTypeDal : IFlatTypeDal
    {
        public void Add(FlatType entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(FlatType entity)
        {
            throw new NotImplementedException();
        }

        public FlatType Get(Expression<Func<FlatType, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<FlatType> GetAll(Expression<Func<FlatType, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(FlatType entity)
        {
            throw new NotImplementedException();
        }
    }
}
