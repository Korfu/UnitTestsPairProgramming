﻿using StringCatKata;
using System;

namespace stringCalcKata
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var sut = new StringCalc();
            sut.Add("//a\n1;x2");
            Console.ReadLine();
        }
    }
}
