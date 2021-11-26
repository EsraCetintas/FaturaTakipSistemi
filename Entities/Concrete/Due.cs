using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
   public class Due:IEntity
    {
        public int Id { get; set; }
        public int ApartmentId { get; set; }
        public int Amount { get; set; }
    }
}
