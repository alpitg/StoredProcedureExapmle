using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StoredProcedure2.Models
{
    public class City
    {
        public int Id { get; set; }


        public int StateId { get; set; }
        public virtual State State { get; set; }


        public string Name { get; set; }

    }
}