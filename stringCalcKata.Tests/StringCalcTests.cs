﻿using NUnit.Framework;
using StringCatKata;
using System;

namespace stringCalcKata.Tests
{
   [TestFixture]
   public class StringCalcTests
    {
        [Test]
        public void Add_empty_input_returnZero()
        {
            //arrange
            var sut = new StringCalc();             //SUT - system under tests

            //act
            var result = sut.Add("");


            //assert
            Assert.AreEqual(0, result);
        }

        [Test]
        public void Add_oneInInput_returnOne()
        {
            //arrange
            var sut = new StringCalc();  

            //act
            var result = sut.Add("1");

            //assert
            Assert.AreEqual(1, result);
        }

        [Test]
        public void Add_singleNumberInput_returnNumber()
        {
            //arrange
            var sut = new StringCalc();

            //act
            var result = sut.Add("5");

            //assert
            Assert.AreEqual(5, result);
        }
        [Test]
        public void Add_twoNumbersSeparatedByComma_returnsTheirSum()
        {
            //arrange
            var sut = new StringCalc();        //SUT - system under tests

            //act
            var result = sut.Add("1,2");

            //assert
            Assert.AreEqual(3, result);
        }
        [Test]
        public void Add_threeNumbers_returnsTheirSum()
        {
            //arrange
            var sut = new StringCalc();        //SUT - system under tests

            //act
            var result = sut.Add("25,1452,22");

            //assert
            Assert.AreEqual(1499, result);
        }
        [Test]
        public void Add_fourNumbersDividedByComma_returnsTheirSum()
        {
            //arrange
            var sut = new StringCalc();        //SUT - system under tests

            //act
            var result = sut.Add("25,1452,22,134234234");

            //assert
            Assert.AreEqual(134235733, result);
        }

        [Test]
        public void Add_addNumbersSeparatedByN_returnsTheirSum()
        {
            //arrange
            var sut = new StringCalc();        //SUT - system under tests

            //act
            var result = sut.Add("1\n2,3");

            //assert
            Assert.AreEqual(6, result);
        }

        [Test]
        public void Add_addDoubleSeprator_returnsTheirSum()
        {
            //arrange
            var sut = new StringCalc();        //SUT - system under tests

            //act
            var result = sut.Add("1\n\n2,3");

            //assert
            Assert.AreEqual(6, result);
        }

        [Test]
        public void Add_addDoubleSepratorWithSpaceInBetween_returnsTheirSum()
        {
            //arrange
            var sut = new StringCalc();        //SUT - system under tests

            //act
            var result = sut.Add("1\n \n, 2,3");

            //assert
            Assert.AreEqual(6, result);
        }

        [Test]
        public void Add_addDoubleSepratorWithManySpaceInBetween_returnsTheirSum()
        {
            //arrange
            var sut = new StringCalc();        //SUT - system under tests

            //act
            var result = sut.Add("1\n                          \n, 2,3");

            //assert
            Assert.AreEqual(6, result);
        }

        [Test]
        public void Add_diffSeparators_returnsTheirSum()
        {
            //arrange
            var sut = new StringCalc();        //SUT - system under tests

            //act
            var result = sut.Add("//;\n1;2");

            //assert
            Assert.AreEqual(3, result);
        }

        [Test]
        public void Add_negativeNumber_returnsException()
        {
            //arrange
            var sut = new StringCalc();      

            //act

            //assert
            Assert.Throws<ArgumentException>(() => { sut.Add("-1\n2,-3");}, "negatives not allowed");
        }
    }
}
