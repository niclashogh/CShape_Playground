using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShape_Playground.Threading
{
    public class _Threading
    {
        public void Method()
        {
            //Method
            Thread meth = new Thread((object? obj) => _method(obj));

            //Lambda
            Thread lamb = new Thread((object? obj) => _lambda(obj));

            //Delegate
            Thread anon = new Thread(delegate (object? obj)
            {
                for (int i = 0; i <= 3; i++)
                {
                    Console.WriteLine(obj);
                }
            });

            //Start Threads
            meth.Start("Hello World (method)");
            meth.Join(); //'Join' skaber en rækkefølge | 'Start' starter processerne (i denne case med flere threads) hver for sig.
            lamb.Start("Hello World (lambda)");
            lamb.Join();
            anon.Start("Hello World (anonym)");
            anon.Join();

            //Await keypress
            Console.ReadKey();
        }

        //method Method
        public static void _method(object obj)
        {
            for (int i = 0; i <= 3; i++)
            {
                Console.WriteLine(obj);
            }
        }

        //lambda Method
        public static void _lambda(object obj)
        {
            for (int i = 0; i <= 3; i++)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
