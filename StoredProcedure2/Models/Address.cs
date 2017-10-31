using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StoredProcedure2.Models
{
    public class Address
    {

        public int Id { get; set; }


        public string PermanentAddress { get; set; }


        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }


        public int StateId { get; set; }


        public int CityId { get; set; }

    }
}