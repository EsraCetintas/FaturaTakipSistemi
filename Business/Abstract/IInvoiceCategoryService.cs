using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
   public interface IInvoiceCategoryService
    {
        List<InvoiceCategory> GetAll();
        InvoiceCategory Get(int id);
        void Add(InvoiceCategory category);
        void Delete(InvoiceCategory category);
        void Update(InvoiceCategory category);
    }
}
