using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solid.Models
{
    //Liskov Substitution - wrong 
    public class JuridicClientWrong : Client 
    {
        public new int CountDiscount()
        {
            return (int)(4 * YearsOfLoyalty);
        }
    }
}
