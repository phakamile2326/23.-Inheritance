using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23.Inheritance
{
    internal class Class2 
        //have a class be able to inherit characteristics if another
        //can have a superclass or other subclasses
    {
        static void Main(string[] args)
        {
            Chef chef = new Chef(); //the chef object
            chef.MakesChicken();

            ItalianChef chef1 = new ItalianChef(); //italian chef suing his inheritance, chef is superclass, italian chef is subclass
            chef1.MakesChicken(); 
            chef1.MakesPasta();
            chef1.MakesChicken();

            //freeze
            Console.ReadLine();
        }

    }

    
}
