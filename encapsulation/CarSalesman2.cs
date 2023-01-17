using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_beginner_course_Encapsulation_Abstraction
{
    public class CarSalesman2 : Salesman
    {
        private int _age;
        public CarSalesman2(string firstName, string lastName, int age) : base(firstName, lastName)
        {
            this._age = age;
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
            Console.WriteLine("Discount on the house - car!");
        }

        protected override void Close()
        {
            Console.WriteLine("Good luck shopping cars!!");
        }
    }
}