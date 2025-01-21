﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Abstract
{
   public interface ICustomerService : IGenericService<Customer>
    {
        List<Customer> GetCustomersListWithJob();
    }
}
