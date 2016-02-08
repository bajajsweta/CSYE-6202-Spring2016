using System;
namespace FizzBuzz
{
    public class FizzBuzz
    {


        public string RunFizzBuzz(int number)
        {
            var result = number.ToString();
            
            if (number == 0)
            {
                return result;
            }
            else if ((number % 3 == 0) && (number % 5 == 0))
            {
                return "FizzBuzz";
            }
            else if (number % 3 == 0)
            {
                return "Fizz";
            }
            else if (number % 5 == 0)
            {
               return "Buzz";
            }
            
            return result;
        }
    }

}
