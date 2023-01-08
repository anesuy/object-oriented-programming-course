using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_beginner_course.without_abstract_class
{
    //1 - an abstract class cannot be instantiated
    //2 - designed to the inherited by another abstrack class or concrete class that either inherit or overwhite its members
    //3 - allows all the components just as a concrete class
    //4 - proprieties and methods, however, can be abstract or virtual
    public class RetailSalesPerson
    {
        private string _firstName;
        private string _lastName;
        public string FullName
        {
            get
            {
                return string.Format("{0} {1}", _firstName, _lastName);
            }
        }

        //this is the constructor. it has the same name as the class
        public RetailSalesPerson(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
        }

        public void Sell()
        {
            Console.WriteLine(string.Format("{0}, RetailsSalesman", FullName));
        }
    }
}
