using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_beginner_course_Polymorphism
{
    public class RetailSalesman : Salesman, SelfDeveloping
    {
        //base: it tell yuo're using the classes constructor
        //it allows the abstract class to set those fields meaning
        // any other class using the salesman class (base class) can have access to those fields as well without having to repeat the same code inside of their own class
        public RetailSalesman(string firstName, string lastName) : base(firstName, lastName)
        {
        }

        public override void Sell()
        {
            Console.WriteLine(string.Format("{0}, RetailSalesPerson2", this.FullName));
        }
        public void Develop()
        {
            Console.WriteLine(string.Format("{0}, RetailsSalesman - I develop myself by watching retail sales training videos.", FullName));
        }
    }
}