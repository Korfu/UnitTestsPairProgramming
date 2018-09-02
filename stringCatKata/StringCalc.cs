using System;
using System.Collections.Generic;
using System.Linq;

namespace StringCatKata
{
    public class StringCalc
    {
        public int Add(string input)
        {
            var separators = new List<string>(){ ",", "\n", "/", ";", "[", "]", "%", "a" };

            for (var i = 0; i< input.Length - 1; i++)
            {
                if (input[i] == '\\')
                {
                    Console.WriteLine(input[i+1].ToString());
                    string newDelimiter = input[i + 1].ToString();
                    separators.Add(newDelimiter);
                }
                Console.WriteLine(input[i] + " " + input[i + 1]);
            }

            var arrayOfStrings = input.Replace(" ", "")
                                       .Split(separators.ToArray(), StringSplitOptions.RemoveEmptyEntries);

            var arrayOfIntigers = arrayOfStrings.Select(x => int.Parse(x));
            var sum = 0;
            foreach (var number in arrayOfIntigers)
            {
                if (number < 0)
                {
                    throw new ArgumentException($"Numbers such as {number} cannot be negative!");
                } else if (number < 1000)
                {
                    sum += number;
                }
            }
            return sum;
        }
    }
}
