using NUnit.Framework;
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
            Assert.AreEqual(47, result);
        }
        [Test]
        public void Add_fourNumbersDividedByComma_returnsTheirSum()
        {
            //arrange
            var sut = new StringCalc();        //SUT - system under tests

            //act
            var result = sut.Add("25,1452,22,134234234");

            //assert
            Assert.AreEqual(47, result);
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
        public void Add_varSeparator_ShouldAcknowledgeIt()
        {
            //arrange
            var sut = new StringCalc();        //SUT - system under tests

            //act
            var result = sut.Add("//x\n1;x2");

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

        [Test]
        public void Add_numberMoreThen1k_returnsTheirSum()
        {
            //arrange
            var sut = new StringCalc();        //SUT - system under tests

            //act
            var result = sut.Add("1000, 2");

            //assert
            Assert.AreEqual(2, result);
        }

        [Test]
        public void Add_Over1kNumber_skipOVer1K()
        {
            //arrange
            var sut = new StringCalc();        //SUT - system under tests

            //act
            var result = sut.Add("999,5,1020");

            //assert
            Assert.AreEqual(1004, result);
        }

        [Test]
        public void Add_stringDelimiters_returnsSumOfAllNumbers()
        {
            //arrange
            var sut = new StringCalc();        //SUT - system under tests

            //act
            var result = sut.Add("//[aaa]\n1aaa2aaa3");

            //assert
            Assert.AreEqual(6, result);
        }

        [Test]
        public void Add_allCharsDelimiters_returnsSumOfAllNumbers()
        {
            //arrange
            var sut = new StringCalc();        //SUT - system under tests

            //act
            var result = sut.Add("//[%][a]\n1%2a3");

            //assert
            Assert.AreEqual(6, result);
        }
    }
}
