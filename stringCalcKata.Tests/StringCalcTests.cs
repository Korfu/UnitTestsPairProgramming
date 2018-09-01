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

    }
}
