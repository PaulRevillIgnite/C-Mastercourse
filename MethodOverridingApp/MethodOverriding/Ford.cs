using System;

namespace MethodOverriding
{
    public class Ford : Car
    {
        public override void SetClock()
        {
            Console.WriteLine("Fiddle with the Ford clock");
        }
    }
}
