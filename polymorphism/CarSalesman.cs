using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_beginner_course_Polymorphism
{
    public class CarSalesman
    {
        private string _firstName;
        private string _lastName;
        public string FullName
        {
            get
            {
                return string.Format("{0} {1}", this._firstName, this._lastName);
            }
        }

        //this is the constructor. it has the same name as the class
        public CarSalesman (string firstName, string lastName) 
        {
            this._firstName = firstName;
            this._lastName = lastName;
        }

        public void Sell()
        {
            Console.WriteLine(String.Format("{0}, CarSalesman", this.FullName));
        }
    }
}
