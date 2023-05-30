using System.Numerics;
using LR6_.Models;

namespace LR6_
{
    public class SampleData
    {
        public static void Initialize(MobileContext context, IWebHostEnvironment env)
        {
            if (!context.Phones.Any())
            {
                context.Phones.AddRange(
                    new Phone
                    {
                        Name = "iPhone X",
                        Company = "Apple",
                        Price = 20000
                    },
                    new Phone
                    {
                        Name = "Samsung Galaxy Edge",
                        Company = "Samsung",
                        Price = 60000
                    },
                    new Phone
                    {
                        Name = "Pixel 3",
                        Company = "Google",
                        Price = 5000
                    },
                    new Phone
                    {
                        Name = "POCO X3 PRO",
                        Company = "POCO",
                        Price = 35000
                    },
                    new Phone
                    {
                        Name = "Xiaomi Redmi 5",
                        Company = "Xiaomi",
                        Price = 20000
                    },
                     new Phone
                     {
                         Name = "z flip 4",
                         Company = "samsung",
                         Price = 50000
                     }
                ); ;

            }

            context.SaveChanges();
        }
    }
}
