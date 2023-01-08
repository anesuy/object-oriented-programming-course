
namespace OOP_beginner_course
{
    class Program
    {
        static void Main(string[] args)
        {
            CarSalesman stevetheSalesman = new CarSalesman("Steve", "Rogers");
            Console.WriteLine(stevetheSalesman.FullName);
            stevetheSalesman.Sell();


        }
    }
}