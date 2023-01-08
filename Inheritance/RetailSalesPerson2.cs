using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_beginner_course
{
    public class RetailSalesPerson2: Salesman
    {
        //base: it tell yuo're using the classes constructor
        //it allows the abstract class to set those fields meaning
        // any other class using the salesman class (base class) can have access to those fields as well without having to repeat the same code inside of their own class
        public RetailSalesPerson2(string firstName, string lastName) : base(firstName, lastName)
        {
        }

        public override void Sell()
        {
            Console.WriteLine(string.Format("{0}, RetailSalesPerson2", this.FullName));
        }
    }
}
