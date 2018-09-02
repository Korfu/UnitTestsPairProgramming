using System;
using System.Collections.Generic;
using System.Linq;

namespace StringCatKata
{
    public class StringCalc
    {
        public int Add(string input)
        {
            var separators = new List<string>(){ ",", "\n", "/", ";", "[", "]", "%", "a","x" };
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

            var arrayOfIntigers = arrayOfStrings.Select(x => int.Parse(x)).ToArray();
            var negativeNumbers = arrayOfIntigers.Where(n => n < 0).ToArray();
            if (negativeNumbers.Any())
            {
                throw new ArgumentException($"Numbers such as {negativeNumbers.First()}cannot be negative!");
            }
            var sum = arrayOfIntigers.Where(n => n < 1000).Sum();
            return sum;
        }
    }
}
