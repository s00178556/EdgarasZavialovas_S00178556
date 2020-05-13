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

        public decimal Price { get; set; }

        public string OperatingSystem { get; set; }

        public string OS_Image { get; set; }

        public string Phone_Image { get; set; }

      
        public virtual Phone phone { get; set; }


    }
    

   


    public class PhoneDescription : DbContext
    {
        public PhoneDescription() : base("MyPhoneDescription") { }
        public DbSet<Phone> Phones { get; set; }

    }

  

}


