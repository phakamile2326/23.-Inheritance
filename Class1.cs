using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23.Inheritance
{
    internal class Chef
    {
        public void MakesChicken()
        {
            Console.WriteLine("This chef makes chicken");
        }
        public void MakeSalad() 
        {
            Console.WriteLine("This chef makes a salad");
        }
        public virtual void MakeSpecialDish() //virtual allows subclasses to override
        {
            Console.WriteLine("This chef makes a special dish");
        }
    }
}
