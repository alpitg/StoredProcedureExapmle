using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StoredProcedure2.ViewModels
{
    public class CustomerViewModel
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string PermanentAddress { get; set; }

        public int StateId { get; set; }

        public int CityId { get; set; }

        //public virtual ICollection<City> City { get; set; }
        //public virtual ICollection<City> City { get; set; }
    }
}