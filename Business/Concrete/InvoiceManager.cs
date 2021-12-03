using Business.Abstract;
using Entities.Concrete;
using Entities.DTO_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class InvoiceManager : IInvoiceService
    {
        public void Add(Invoice invoice)
        {
            throw new NotImplementedException();
        }

        public void Delete(Invoice invoice)
        {
            throw new NotImplementedException();
        }

        public Invoice Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Invoice> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<InvoiceDetailDto> GetInvoiceDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Invoice invoice)
        {
            throw new NotImplementedException();
        }
    }
}
