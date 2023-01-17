using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_beginner_course_Encapsulation_Abstraction
{
    public abstract class Salesman
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
        public Salesman(string firstName, string lastName)
        {
            this._firstName = firstName;
            this._lastName = lastName;
        }

        //declaring abstract here because it's the method that differs alone from the two concrete classes case
        //Encapsulation on its own it's just a blind processof showing and hiding things.
        //Why we decide to encapsulate information is the Abstraction.
        //We only show what's relevant to the user and that's abtraction.
        //We only show what's relevant to the user which is why we hide certain things and show other things.

        public void Sell()
        {
            this.Engage();
            this.AddressConcerns();
            this.DemoValue();
            this.Close();
        }

        protected abstract void Engage();

        protected abstract void AddressConcerns();

        protected abstract void DemoValue();

        protected abstract void Close();

    }
}