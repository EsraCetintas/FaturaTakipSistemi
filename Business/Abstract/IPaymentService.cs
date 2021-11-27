using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
   public interface IPaymentService
    {
        List<Payment> GetAll();
        Payment Get(int id);
        void Add(Payment payment);
        void Delete(Payment payment);
        void Update(Payment payment);
    }
}
