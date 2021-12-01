﻿using Core.Entities;
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
        public int FlatId { get; set; }
        public int Amount { get; set; }
    }
}
