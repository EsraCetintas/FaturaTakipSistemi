using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTO_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfInvoiceDal : EfEntityRepositoryBase<Invoice, FTSContext>, IInvoiceDal
    {
        public List<InvoiceDetailDto> GetInvoiceDetails()
        {
            using (FTSContext context=new FTSContext())
            {
                var result = from i in context.Invoices
                             join c in context.Categories
                             on i.CategoryId equals c.Id
                             select new InvoiceDetailDto
                             {
                                 InvoiceId=i.Id,CategoryName=c.CategoryName,Amount=i.Amount
                             };
                return result.ToList();
            }
           
        }
    }
}
