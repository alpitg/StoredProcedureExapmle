using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StoredProcedure2.Models
{
    public class Customer
    {
        public int Id { get; set; }

        
        public string Name{ get; set; }

        
        public string Email { get; set; }

        public virtual List<Address> Address { get; set; }
    }
}