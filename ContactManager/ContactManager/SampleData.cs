using ContactManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactManager
{
    public class SampleData
    {
        public static void Initialize(UserContext context)
        {
            if (context.Users.Any())
            {
                return;   // DB has been seeded
            }
            context.Users.AddRange(
                    new User
                    {
                        Name = "Lilya Karas",
                        BirthDay = new DateTime(1993,10,23),
                         IsMarried = true,
                        Phone = "0967983710",
                        Salary=10000
                    },
                     new User
                     {
                         Name = "Petro Vasylkiv",
                         BirthDay = new DateTime(1995, 03, 05),
                         IsMarried = false,
                         Phone = "0973896512",
                         Salary = 10000
                     }                  
                );
            context.SaveChanges();
        }
    }
}
