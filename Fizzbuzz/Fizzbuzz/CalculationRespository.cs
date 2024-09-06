using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fizzbuzz
{
    public class CalculationRespository : ICalculation
    {
        public string GetCalculationResults(string values)
        {
            StringBuilder str = new StringBuilder();
            if (!string.IsNullOrEmpty(values))
            {
                string[] strArr = values.Split(',');
                foreach (var item in strArr)
                {
                    bool charactercheck  = item.All(char.IsDigit);
                    if (charactercheck)
                    {
                        int intValue = Convert.ToInt32(item);

                        if (intValue > 0)
                        {
                            if (intValue % 3 == 0 && intValue % 5 == 0)
                            {
                                str.Append(GetFizzBuzz(intValue));
                            }
                            else if (intValue % 5 == 0)
                            {
                                str.Append(GetBuzz(intValue));
                            }
                            else if (intValue % 3 == 0)
                            {
                                str.Append(GetFizz(intValue));
                            }
                            else
                            {
                                str.Append(GetDefault(intValue));
                            }
                        }
                        else
                        {
                            str.Append(GetZero(intValue));
                        }
                    }
                    else
                    {
                        str.Append("Invalid term ==>" + item + "\n");
                    }
                }
            }
            else
            {
                return "Invalid Terms";
            }

            return str.ToString();
        }

        public string GetDefault(int value)
        {
            return "Divided " + value + " by 3 \n " + "Divided " + value + " by 5 \n";
        }

        public string GetZero(int value)
        {

            return "Divided " + value + " by 0 ==>0 \n ";
        }

        public string GetFizzBuzz(int value)
        {
            return value + "==>FizzBuzz \n";
        }

        public string GetBuzz(int value)
        {
            return value + "==>Buzz \n";
        }

        public string GetFizz(int value)
        {
            return value + "==>Fizz \n";
        }
    }
}
