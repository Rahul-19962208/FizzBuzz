using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fizzbuzz
{
    public class BuzzClass : IGetValueTypes
    {
        public string GetTypes(int values)
        {
            return values + "==>Buzz \n";
        }
    }
}
