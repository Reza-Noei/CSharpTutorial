using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TutorialNoei
{
    internal class LambdaExpressions
    {
        public static void A()
        {

        }

        public void Configure(Action<int, int> conf)
        {

        }

        public LambdaExpressions()
        {
            Func<int, int, int, int> a = (int x, int y, int z) => x + 2;

            Func<int, int, int> b = (x, y) => x + y;            

            Func<int, int , int> c = (x , _) => x + 2;

            Action<int, int, int> cc = (x, _, _) => x = x + 2;

            // var a = x => x + 2;
        
            Func<int, int , int> d = (int x , int y = 10) => x + y;

            int aa = 550;

            // Closure
            Action act = () =>
            {
                aa++;
            };

            aa = 600;

            act();

            Func<int> natural = Natural();
            //Console.WriteLine(natural()); // 0
            //Console.WriteLine(natural()); // 1
            //Console.WriteLine(natural()); // 2

            Action[] actions = new Action[3];
            int i = 0;
            actions[0] = () => Console.Write(i);
            i = 1;
            actions[1] = () => Console.Write(i);
            i = 2;
            actions[2] = () => Console.Write(i);
            i = 3;
            foreach (Action ac in actions) 
                ac(); // 333

            actions = new Action[3];
            for (int j = 0; j < 3; j++)
            {
                int loopScopedj = j;
                actions[j] = () => Console.Write(loopScopedj);
            }

            foreach(Action actj in actions) actj(); // 012

            // Local methods have the following three advantages:
            //      1. They can be recursive(they can call themselves) without ugly hacks.
            //      2. They avoid the clutter of specifying a delegate type.
            //      3. They incur slightly less overhead
        }

        Func<int> Natural()
        {
            int seed = 0;
            return () => ++seed; // Returns a closure
        }    
    }
}
