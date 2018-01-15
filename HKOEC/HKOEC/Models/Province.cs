using System;
using System.Collections.Generic;

namespace HKOEC.Models
{
    public partial class Province
    {
        public Province()
        {
            Farm = new HashSet<Farm>();
        }

        public string ProvinceCode { get; set; }
        public string Name { get; set; }
        public string CountryCode { get; set; }

        public virtual ICollection<Farm> Farm { get; set; }
        public virtual Country CountryCodeNavigation { get; set; }
    }
}
