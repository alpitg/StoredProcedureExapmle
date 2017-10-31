using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StoredProcedure2.Models
{
    public class State
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual List<City> City { get; set; }
    }
}