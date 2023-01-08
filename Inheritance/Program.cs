using OOP_beginner_course;
using OOP_beginner_course.without_abstract_class;

namespace OOP_Inheritance

{
    class Program
    {
        static void Main(string[] args)
        {
            //using concrete class
                CarSalesman stevetheSalesman = new CarSalesman("Steve", "Rogers");
                Console.WriteLine(stevetheSalesman.FullName);
                stevetheSalesman.Sell();


                // the console.WriteLine() in the Sell() method is different but there's a lot of repeated code just because if this one method.
                // it's one of cons of having therese two concrete classes
                RetailSalesPerson retailSalesPerson = new RetailSalesPerson("Steve", "Rogers");
                Console.WriteLine(retailSalesPerson.FullName);
                retailSalesPerson.Sell();

            //using abstract class
                CarSalesman2 stevetheSalesman2 = new CarSalesman2("Steve", "Rogers", 10);
                Console.WriteLine(stevetheSalesman2.FullName);
                stevetheSalesman2.Sell();

                RetailSalesPerson2 retailSalesPerson2 = new RetailSalesPerson2("Steve", "Rogers");
                Console.WriteLine(retailSalesPerson2.FullName);
                retailSalesPerson2.Sell();

        }
    }
}