using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryInvoiceDal : IInvoiceDal
    {
        public void Add(Invoice invoice)
        {
            throw new NotImplementedException();
        }
      
        public void Delete(Invoice invoice)
        {
            throw new NotImplementedException();
        }

        public Invoice Get()
        {
            throw new NotImplementedException();
        }

        public List<Invoice> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Invoice invoice)
        {
            throw new NotImplementedException();
        }
    }
}
