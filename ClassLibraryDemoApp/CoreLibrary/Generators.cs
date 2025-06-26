using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLibrary
{
    public class Generators
    {
        public string WelcomeMessage(string title, string lastName)
        {
            return $"Welcome to our demo application {title} {lastName}";
        }

        public string FarewellMessage(string title, string lastName)
        {
            return $"I hope you enjoyed your time with us {title} {lastName}. Come back soon.";
        }
    }
}
