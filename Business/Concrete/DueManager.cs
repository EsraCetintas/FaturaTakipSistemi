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
    public class DueManager : IDueService
    {
        IDueDal _dueDal;

        public DueManager(IDueDal dueDal)
        {
            _dueDal = dueDal;
        }

        public void Add(Due due)
        {
            _dueDal.Add(due);
        }

        public void Delete(Due due)
        {
            throw new NotImplementedException();
        }

        public Due Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Due> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Due due)
        {
            throw new NotImplementedException();
        }
    }
}
