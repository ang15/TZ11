using System.Collections;
using System.Collections.Generic;
using System;

namespace Script
{
    public class Log
    {
        public int Ganerate()
        {
            Random random = new Random();
            return random.Next(0, 15);
        }

    }
}