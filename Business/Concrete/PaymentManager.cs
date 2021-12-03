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
    public class PaymentManager : IPaymentService
    {
        IPaymentDal _paymentDal;

        public PaymentManager(IPaymentDal paymentDal)
        {
            _paymentDal = paymentDal;
        }

        public void Add(Payment payment)
        {
            _paymentDal.Add(payment);
        }

        public void Delete(Payment payment)
        {
            _paymentDal.Delete(payment);
        }

        public Payment Get(int id)
        {
           return _paymentDal.Get(p=>p.Id==id);
        }

        public List<Payment> GetAll()
        {
            return _paymentDal.GetAll();
        }

        public void Update(Payment payment)
        {
            _paymentDal.Update(payment);
        }
    }
}
