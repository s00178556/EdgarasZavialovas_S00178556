using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdgarasZavialovas_S00178556
{
    public class Phone
    {
        public string Name { get; set; }

        public decimal price { get; set; }

        public string OperatingSystem { get; set; }

        public string OS_Image { get; set; }

        public string Phone_Image { get; set; }

        //public decimal IncreasedPrice

        public virtual List<Phone> Phones { get; set; }
    }
    public class PhoneDescription : DbContext
    {
        public PhoneDescription() : base("PhoneDescription") { }
        public DbSet<Phone> Phones { get; set; }

    }

}


