using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer.Concrete
{
   public class Job
    {
        public int JobID { get; set; }
        public string Name { get; set; }
        public List<Customer> Customers { get; set; }
    }
}
