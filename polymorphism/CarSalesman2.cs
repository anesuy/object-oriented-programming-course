using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_beginner_course
{
    public class CarSalesman2 : Salesman
    {
        private int _age;
        public CarSalesman2(string firstName, string lastName, int age) : base(firstName, lastName)
        {
            this._age = age;
        }

        public override void Sell()
        {
            Console.WriteLine(string.Format("{0}, CarSalesman2", this.FullName));
        }
    }
}