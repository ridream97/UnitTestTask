using Solid.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solid.Models
{
    //Liskov Substitution - correct
    public class JuridicClient : IClient
    {
        public string Name { get; set; }
        public string Adress { get; set; }
        public int BirthYear { get; set; }
        public int YearsOfLoyalty { get; set; }

        public int CountDiscount()
        {
            return (int)(4 * YearsOfLoyalty);
        }
    }
}
