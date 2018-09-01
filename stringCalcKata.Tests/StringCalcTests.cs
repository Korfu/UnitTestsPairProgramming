using NUnit.Framework;
using StringCatKata;

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
            var sut = new StringCalc();        //SUT - system under tests

            //act
            var result = sut.Add("1");

            //assert
            Assert.AreEqual(1, result);
        }
        [Test]
        public void Add_twoNumbersSeparatedByComma_returnsTheirSum()
        {
            //arrange
            var sut = new StringCalc();        //SUT - system under tests

            //act
            var result = sut.Add("1");

            //assert
            Assert.AreEqual(1, result);
        }
    }
}
