using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_beginner_course_Encapsulation
{
    public class RetailSalesman : Salesman, SelfDeveloping
    {
        //base: it tell yuo're using the classes constructor
        //it allows the abstract class to set those fields meaning
        // any other class using the salesman class (base class) can have access to those fields as well without having to repeat the same code inside of their own class
        public RetailSalesman(string firstName, string lastName) : base(firstName, lastName)
        {
        }

        //what if at some point, a different and incorrect order is implemented?
        //then, we should lock this method fot it not to be overwriten: making it CONCRETE
        //we'll put it in the interface class and same some coding lines

        //public override void Sell()
        //{
        //    this.Engage();
        //    this.AddressConcerns();
        //    this.DemoValue();
        //    this.Close();
        //}
        public void Develop()
        {
            Console.WriteLine(string.Format("{0}, RetailsSalesman - I develop myself by watching retail sales training videos.", FullName));
        }

        protected override void Engage()
        {
            Console.WriteLine("Hello!");
        }

        protected override void AddressConcerns()
        {
            Console.WriteLine("Help is on the way!");
        }

        protected override void DemoValue()
        {
            Console.WriteLine("Discount on the house!");
        }

        protected override void Close()
        {
            Console.WriteLine("Good shopping!!");
        }
    }
}