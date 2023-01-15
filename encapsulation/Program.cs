

using OOP_beginner_course_Encapsulation;

namespace OOP_beginner_course_Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            RetailSalesman retailSalesman = new RetailSalesman("Name 1", "Name 2");
            retailSalesman.Sell();

            CarSalesman2 carSalesman2 = new CarSalesman2("Name 1", "Name 2", 2);
            carSalesman2.Sell();
        }
    }

}
