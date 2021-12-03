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
    public class FlatManager : IFlatService
    {
        IFlatDal _flatDal;

        public FlatManager(IFlatDal flatDal)
        {
            _flatDal = flatDal;
        }

        public void Add(Flat flat)
        {
            _flatDal.Add(flat);
        }

        public void Delete(Flat flat)
        {
            _flatDal.Delete(flat);
        }

        public Flat Get(int id)
        {
            return _flatDal.Get(f => f.Id == id);
        }

        public List<Flat> GetAll()
        {
            return _flatDal.GetAll();
        }

        public void Update(Flat flat)
        {
            _flatDal.Update(flat);
        }
    }
}
