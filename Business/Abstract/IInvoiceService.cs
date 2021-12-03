﻿using Entities.Concrete;
using Entities.DTO_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IInvoiceService
    {
        List<Invoice> GetAll();
        Invoice Get(int id);
        void Add(Invoice invoice);
        void Delete(Invoice invoice);
        void Update(Invoice invoice);
        List<InvoiceDetailDto> GetInvoiceDetails();

    }
}
