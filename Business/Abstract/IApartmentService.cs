using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
   public interface IApartmentService
    {
        List<Apartment> GetAll();
        Apartment Get(int id);
        IResult Add(Apartment apartment);
        IResult Delete(Apartment apartment);
        IResult Update(Apartment apartment);
    }
}
