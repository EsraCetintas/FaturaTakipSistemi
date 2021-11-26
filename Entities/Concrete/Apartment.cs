using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
   public class Apartment:IEntity
    {
        public int Id { get; set; }
        public int ApartmentTypeId { get; set; }
        public int UserId { get; set; }
        public int BlokNo { get; set; }
        public int FloorNo { get; set; }
        public bool State { get; set; }
       
    }
}
