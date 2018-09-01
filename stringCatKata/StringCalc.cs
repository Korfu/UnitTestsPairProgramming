using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCatKata
{
    public class StringCalc
    {
        public int Add(string input)
        {
            if (input == "")
            {
                return 0;
             
            }
            else
            {
                var arrayOfStrings = input.Replace(" ", "").Split(new[] { ",", "\n","/",";","aaa","[","]" },StringSplitOptions.RemoveEmptyEntries);
                var arrayOfIntigers = new List<int>();
                var sum = 0;
                foreach (var element in arrayOfStrings)
                {
                    var number = int.Parse(element);
                    if (number < 0)
                    {
                        throw new ArgumentException("Numbers cannot be negative!");
                    }
                    arrayOfIntigers.Add(number);
                    sum += number;
                }

                return sum%1000;
            }




            //if (input == "")
            //{
            //    return 0;
            //} else
            //{
            //    return int.Parse(input);
            //}
        }
    }
}
