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
    public class FlatTypeManager : IFlatTypeService
    {
        IFlatTypeDal _flatTypeDal;

        public FlatTypeManager(IFlatTypeDal flatTypeDal)
        {
            _flatTypeDal = flatTypeDal;
        }

        public void Add(FlatType flatType)
        {
            _flatTypeDal.Add(flatType);
        }

        public void Delete(FlatType flatType)
        {
            _flatTypeDal.Add(flatType);
        }

        public FlatType Get(int id)
        {
            return _flatTypeDal.Get(f=>f.Id==id);
        }

        public List<FlatType> GetAll()
        {
           return _flatTypeDal.GetAll();
        }

        public void Update(FlatType flatType)
        {
            _flatTypeDal.Add(flatType);
        }
    }
}
