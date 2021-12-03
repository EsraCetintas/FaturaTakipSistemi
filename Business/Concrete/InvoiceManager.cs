using Business.Abstract;
using DataAccess.Abstract;
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
        IInvoiceDal _invoiceDal;

        public InvoiceManager(IInvoiceDal invoiceDal)
        {
            _invoiceDal = invoiceDal;
        }

        public void Add(Invoice invoice)
        {
            _invoiceDal.Add(invoice);
        }

        public void Delete(Invoice invoice)
        {
            _invoiceDal.Delete(invoice);
        }

        public Invoice Get(int id)
        {
            return _invoiceDal.Get(i=>i.Id==id);
        }

        public List<Invoice> GetAll()
        {
            return _invoiceDal.GetAll();
        }

        public List<InvoiceDetailDto> GetInvoiceDetails()
        {
            return _invoiceDal.GetInvoiceDetails();
        }

        public void Update(Invoice invoice)
        {
            _invoiceDal.Update(invoice);
        }
    }
}
