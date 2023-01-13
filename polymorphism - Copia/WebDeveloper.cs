using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_beginner_course_Encapsulation
{
    public class WebDeveloper : Developer, SelfDeveloping
    {
        public WebDeveloper(string mainDevLanguage) : base(mainDevLanguage)
        {
        }

        public void Develop()
        {
            Console.WriteLine("I develop myself by watching Udemy web development courses");
        }
    }
}
