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
using System.Security.Cryptography;


namespace NameGenerator
{
    public class DiceRoll : IDiceRoll
    {
        readonly RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();

        public int Roll(int numberSides)
        {
            if (numberSides == 0)
            {
                throw new InvalidOperationException("You can not have a 0 sided dice.");
            }

            if (numberSides > 255)
            {
                throw new InvalidOperationException("You can not have dice with " + numberSides + " sides.");
            }

            var oneByte = new byte[1];
            var max = byte.MaxValue - byte.MaxValue % numberSides;

            while (true)
            {
                rng.GetBytes(oneByte);

                if (oneByte[0] < max)
                {
                    return oneByte[0] % numberSides + 1;
                }
            }
        }
    }
}