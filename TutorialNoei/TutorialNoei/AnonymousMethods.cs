using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorialNoei
{
    internal class AnonymousMethods
    {
        // Anonymous methods (Subset of LambdaExpression) lacks of following features: 
        //      1. Implicitly typed parameters
        //      2. Expression syntax(an anonymous method must always be a statement block)
        //      3. The ability to compile to an expression tree, by assigning to Expression<T>

        public AnonymousMethods()
        {
            var aaa = delegate (int x) // Equals to x => x * x;
            {
                return x * x;
            };

            Clicked += delegate (object s, EventArgs e) 
            { 
            
            };

            Clicked += delegate 
            {
                Console.WriteLine("Clicked");
            };
        }

        public event EventHandler Clicked = delegate { };
    }
}
