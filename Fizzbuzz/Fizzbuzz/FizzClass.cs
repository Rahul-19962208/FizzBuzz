using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fizzbuzz
{
    public class FizzClass : IGetValueTypes
    {      

        public string GetTypes(int values)
        {
            return values + "==>Fizz \n";
        }
    }
}
