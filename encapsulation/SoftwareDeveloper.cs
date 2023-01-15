using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_beginner_course_Encapsulation
{
    //a class can inherit from one class only but it can inherit from multiple interfaces
    public class SoftwareDeveloper : Developer, SelfDeveloping
    {
        public SoftwareDeveloper(string mainDevLanguage) : base(mainDevLanguage)
        {
        }

        //we cannot change the type of return of the method, its name, only its IMPLEMENTATION
        public void Develop()
        {
            throw new NotImplementedException();
        }
    }
}
