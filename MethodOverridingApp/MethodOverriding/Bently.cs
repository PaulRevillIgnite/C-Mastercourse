﻿using System;

namespace MethodOverriding
{
    public class Bently : Car
    {
        public override void StartCar()
        {
            Console.WriteLine("Think about your destination");
        }

        public override void SetClock()
        {
            Console.WriteLine("It sets itself");
        }
    }
}
