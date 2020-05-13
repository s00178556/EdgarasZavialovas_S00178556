using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EdgarasZavialovas_S00178556;

namespace DataManagmentPhone
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneDescription db = new PhoneDescription();

            using(db)
            {
                Phone p1 = new Phone() { Name = "Samsung S20", price = 500, OperatingSystem = "Android", OS_Image = "/Images/android.png", Phone_Image = "/Images/s20.jpg" };
                Phone p2 = new Phone() { Name = "iPhone 11", price = 600, OperatingSystem = "IOS", OS_Image = "/Images/apple.png", Phone_Image = "/Images/iphone11.jpg" };

                db.Phones.Add(p1);
                db.Phones.Add(p2);

                Console.WriteLine("Added Phones To Database");

                db.SaveChanges();

                Console.WriteLine("Saved to Database");
            }
        }
    }
}
