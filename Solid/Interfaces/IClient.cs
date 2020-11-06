using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solid.Interfaces
{
    public interface IClient
    {
        string Name { get; set; }
        string Adress { get; set; }
        int BirthYear { get; set; }
        int YearsOfLoyalty { get; set; }

        int CountDiscount();
    }
}
