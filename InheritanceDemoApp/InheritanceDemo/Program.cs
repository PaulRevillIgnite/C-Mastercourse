using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            LandLine homePhone = new LandLine();
            MobilePhone nokia3310 = new MobilePhone();
            SmartPhone googlePixle = new SmartPhone();

            //Phone phone = new SmartPhone();

            List<Phone> phones = new List<Phone>();

            phones.Add(new MobilePhone());
            phones.Add(new SmartPhone());

            foreach (var phone in phones)
            {
                phone.PlaceCall();

                if (phone is MobilePhone cell)
                {
                    cell.Carrier = "EE";
                }

                if (phone is SmartPhone smartPhone)
                {
                    smartPhone.ConnectToInternet();
                }
            }

            Console.ReadLine();
        }
    }
}
