using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
   public class Invoice:IEntity
    {
        public int Id { get; set; }
        public int FlatId { get; set; }
        public int CategoryId { get; set; }
        public decimal Amount { get; set; }
        public DateTime? PaymentDate { get; set; }
        public DateTime? Deadline { get; set; }
    }
}
