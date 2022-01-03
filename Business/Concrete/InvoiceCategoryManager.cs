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
    public class InvoiceCategoryManager : IInvoiceCategoryService
    {
        IInvoiceCategoryDal _categoryDal;

        public InvoiceCategoryManager(IInvoiceCategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void Add(InvoiceCategory category)
        {
            _categoryDal.Add(category);
        }

        public void Delete(InvoiceCategory category)
        {
            _categoryDal.Delete(category);
        }

        public InvoiceCategory Get(int id)
        {
            return _categoryDal.Get(c=>c.Id==id);
        }

        public List<InvoiceCategory> GetAll()
        {
           return _categoryDal.GetAll();
        }

        public void Update(InvoiceCategory category)
        {
            _categoryDal.Update(category);
        }
    }
}
