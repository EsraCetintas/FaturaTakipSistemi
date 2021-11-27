using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
   public interface IInvoiceDal
    {
        List<Invoice> GetAll();
        Invoice Get(int id);
        void Add(Invoice invoice);
        void Delete(Invoice invoice);
        void Update(Invoice invoice);
    }
}
