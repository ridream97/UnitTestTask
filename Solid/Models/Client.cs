using Solid.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solid.Models
{
    public class Client : IClient
    {
        public string Name { get; set; }
        public string Adress { get; set; }
        public int BirthYear { get; set; }
        public int YearsOfLoyalty { get; set; }

        //Single responsability - wrong
        public int CountDiscount()
        {
            var age = DateTime.Now.Year - BirthYear;

            return YearsOfLoyalty > 5 ? age + YearsOfLoyalty : age - YearsOfLoyalty;
        }
    }
}
