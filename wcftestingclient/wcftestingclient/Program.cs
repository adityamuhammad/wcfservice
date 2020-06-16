using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wcftestingclient.ServiceReference1;

namespace wcftestingclient
{
    class Program
    {
        static void Main(string[] args)
        {
            Service1Client service1Client = new Service1Client();
            string[] names = { "adit", "nani", "lala", "lili" };
            string[] uppercaseName = service1Client.GetUpperCaseData(names);

            for (int i = 0; i < uppercaseName.Length; ++i)
                Console.WriteLine(uppercaseName[i]);

            Console.WriteLine(service1Client.GetData(1));
            Console.ReadKey();
        }
    }
}
