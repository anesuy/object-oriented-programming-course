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

        //    public virtual void Code(string firstExtraDevLanguage = null, string secondExtraDevLanguage = null)
        //    {
        //        if (firstExtraDevLanguage == null && secondExtraDevLanguage == null)
        //        {
        //            Console.WriteLine(string.Format("I'm coding in my favorite programming language {0}", this._mainDevLanguage));
        //        }

        //        else if (firstExtraDevLanguage != null && secondExtraDevLanguage != null)
        //        {
        //            Console.WriteLine(string.Format("I'm coding in my favorite programming language {0}, and {1} and {2}", this._mainDevLanguage, firstExtraDevLanguage, secondExtraDevLanguage));
        //        }

        //        else if (firstExtraDevLanguage != null)
        //        {
        //            Console.WriteLine(string.Format("I'm coding in my favorite programming language {0}, and {1}", this._mainDevLanguage, firstExtraDevLanguage));
        //        }

        //        else if (secondExtraDevLanguage != null)
        //        {
        //            Console.WriteLine(string.Format("I'm coding in my favorite programming language {0}, and {1}", this._mainDevLanguage, secondExtraDevLanguage));
        //        }
        //    }


        //static polymorphism happens during compile time
        //this way, we`re basically determining it`s different behaviour as we`re writing our code, bot while the code is running.
        //it's much cleaner and more readable;

        //same form but different behaviour
        //less room for errors

        public virtual void Code()
        {
            Console.WriteLine(string.Format("I'm coding in my favorite programming language {0}", this._mainDevLanguage));
        }

        public virtual void Code(string firstExtraDevLanguage = null)
        {
            Console.WriteLine(string.Format("I'm coding in my favorite programming language {0}, and {1}", this._mainDevLanguage, firstExtraDevLanguage));
        }

        public virtual void Code(string firstExtraDevLanguage = null, string secondExtraDevLanguage = null)
        {
            Console.WriteLine(string.Format("I'm coding in my favorite programming language {0}, and {1} and {2}", this._mainDevLanguage, firstExtraDevLanguage, secondExtraDevLanguage));
        }
    }
}
