using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23.Inheritance
{
    internal class ItalianChef:Chef //this makes Italian Chef inherit all there is in Chef, can now call methods in Chef!
    {
        public void MakesPasta()
        {
            Console.WriteLine("Makes Pasta");
        }
        public override void MakeSpecialDish() //use keyword overrides
        {
            Console.WriteLine("The chef makes Italianspecials ");
        }
        //this class inherits from superclass, extends superclass by making new functions and also overrides some superclass functions
    }
}
