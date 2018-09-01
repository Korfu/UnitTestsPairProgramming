using NUnit.Framework;
using StringCatKata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringCalcKata.Tests
{
   [TestFixture]
   public class StringCalcTests
    {
        [Test]
        public void Add_empty_input_returnZero()
        {
            //arrange
            var sut = new StringCalc();        //SUT - system under tests

            //act
            var result = sut.Add("");

            //assert
            Assert.AreEqual(0, result);
        }
    }
}
