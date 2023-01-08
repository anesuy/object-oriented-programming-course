using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_beginner_course
{
    public abstract class Developer
    {
        private string _mainDevLanguage;
        
        //this is the constructor. it has the same name as the class
        public Developer(string mainDevLanguage)
        {
            this._mainDevLanguage = mainDevLanguage;
            
        }

        //declaring abstract here because it's the method that differs alone from the two concrete classes case
        public virtual void Code()
        {
            Console.WriteLine(string.Format("I'm coding in my favorite programming language {0}", this._mainDevLanguage));
        }

    }
}
