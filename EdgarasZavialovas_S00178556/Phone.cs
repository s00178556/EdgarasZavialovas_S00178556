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

        public void percentagePrice(decimal v)
        {
            throw new NotImplementedException();
        }

        public string Phone_Image { get; set; }


        public virtual Phone phone { get; set; }

        public decimal percentagePrice(string userInput, Phone phone)
        {
            int entered = 0;
            try
            {
                entered = int.Parse(userInput);
            }
            catch (Exception)
            {
                throw;
            }

            if (entered != 0)
            {
                decimal percentage = entered / 50;
                decimal TakeAway = phone.Price * percentage;
                decimal afterDiscount = TakeAway - phone.Price;

                Value(phone, afterDiscount);

            }
            return phone.Price;
        } 

        private void Value(Phone phone, decimal afterDiscount)
        {
           phone.Price = afterDiscount;
        }
    }
    

   


    public class PhoneDescription : DbContext
    {
        public PhoneDescription() : base("MyPhoneDescription") { }
        public DbSet<Phone> Phones { get; set; }

    }

  

}


