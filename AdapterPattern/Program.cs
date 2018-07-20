using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Target target = new Adapter();
            target.Request();

            Console.ReadKey();
        }



        public class  Target
        {
            public virtual void Request()
            {
                Console.WriteLine("Called Target Reqeust()");
            }
            
        }

        public class Adaptee
        {
            public void SpecificRequest()
            {
                Console.WriteLine("Called SpecificRequest()");
            }
            
        }

        class Adapter : Target
        {
            private Adaptee _adaptee = new Adaptee(); 

            public void Request()
            {
                _adaptee.SpecificRequest();

            }
        }

    }
}
