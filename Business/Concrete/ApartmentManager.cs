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
    public class ApartmentManager : IApartmentService
    {
        IApartmentDal _apartmentDal;

        public ApartmentManager(IApartmentDal apartmentDal)
        {
            _apartmentDal = apartmentDal;
        }

        public IResult Add(Apartment apartment)
        {
            _apartmentDal.Add(apartment);
        }

        public IResult Delete(Apartment apartment)
        {
            _apartmentDal.Delete(apartment);
        }

        public Apartment Get(int id)
        {
            return _apartmentDal.Get(a=>a.Id==id);
        }

        public List<Apartment> GetAll()
        {
           return _apartmentDal.GetAll();
        }

        public IResult Update(Apartment apartment)
        {
            _apartmentDal.Update(apartment);
        }
    }
}
