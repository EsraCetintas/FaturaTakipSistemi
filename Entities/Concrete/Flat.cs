using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
   public class Flat:IEntity
    {
        public int Id { get; set; }
        public int FlatTypeId { get; set; }
        public int UserId { get; set; }
        public int ApartmentId { get; set; }
        public int FloorNo { get; set; }
        public int FlatNo { get; set; }
        public bool State { get; set; }
       
    }
}
