﻿/*
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
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NameGenerator.Tests.Unit
{
    [TestClass]
    public class NameTests
    {
        [TestMethod]
        public void CreateReturnsEmptyStringIfComplexityIsZero()
        {
            Assert.AreEqual(string.Empty, Name.Create(0));
        }

        [TestMethod]
        public void CreateReturnsNonEmptyNameForComplexityOfOne()
        {
            Assert.AreNotEqual(string.Empty, Name.Create(1));
        }

        [TestMethod]
        public void CreateReturnsNonRepeatingName()
        {
            string nameOne = Name.Create(5);
            string nameTwo = Name.Create(5);

            Assert.AreNotEqual(nameOne, nameTwo);
        }

        [TestMethod]
        public void GenerateNamesOfDifferentLengths()
        {
            string nameOne = Name.Create(5);
            string nameTwo = Name.Create(6);
            string nameThree = Name.Create(7);
            string nameFour = Name.Create(8);
            string nameFive = Name.Create(9); 

            Assert.AreNotEqual(string.Empty, nameOne);
            Assert.AreNotEqual(string.Empty, nameTwo);
            Assert.AreNotEqual(string.Empty, nameThree);
            Assert.AreNotEqual(string.Empty, nameFour);
            Assert.AreNotEqual(string.Empty, nameFive);

        }
    }
}