/*
MIT License
Copyright (c) 2019 
Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:
The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.
THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
*/

using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NameGenerator;

namespace NameGenerator.Tests.Unit
{
    [TestClass]
    public class DiceRollTests
    {
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void RollDiceForZeroSidedDiceThrowsInvalidOperationException()
        {
            var dice = new DiceRoll();
            dice.Roll(0);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void RollDiceFor256SidedDiceThrowsInvalidOperationException()
        {
            var dice = new DiceRoll();
            dice.Roll(256);
        }

        [TestMethod]
        public void RollDiceFor255SidedDiceReturnsRandomNumberLessThan255()
        {
            var dice = new DiceRoll();
            var number = dice.Roll(255);

            Assert.IsTrue(number < 255);
        }

        [TestMethod]
        public void RollDice100TimesForEachSideCombinationfrom1To256()
        {
            for (int i = 1; i < 256; i++)
            {
                TestDiceRange(i);
            }
        }

        private static void TestDiceRange(int numSides)
        {
            var numbers = new List<int>();
            var dice = new DiceRoll();

            for (var i = 0; i < 100; i++)
            {
                numbers.Add(dice.Roll(numSides));
            }

            foreach (var number in numbers)
            {
                Assert.IsTrue(number > 0);
                Assert.IsTrue(number <= numSides);
            }
        }
    }
}