

//WebDeveloper minWebDeveloper = new WebDeveloper("Typescript");
//minWebDeveloper.Code();
//minWebDeveloper.Code("C#");
//minWebDeveloper.Code("C#", "Phyton");
//minWebDeveloper.Code(null, "C#");

using OOP_beginner_course_Polymorphism;

namespace OOP_beginner_course
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    List<Object> salesman = new List<object>() { new CarSalesman2("One", "Two"), new RetailSalesPerson("Three", "Four"), new InsuranceBroker("Five", "Six")};

        //    foreach(var item in salesman)
        //    {
        //        showMeHowTOSell(item);
        //    }
        //}

        //static void showMeHowTOSell(Object salesman)
        //{
        //    if (salesman is CarSalesman2)
        //    {
        //        CarSalesman2 carSalesman = (CarSalesman2)salesman;
        //        //(to) from
        //        //casting
        //        carSalesman.Sell();
        //    }
        //    if (salesman is RetailSalesPerson)
        //    {
        //        RetailSalesPerson retailSalesPerson = (RetailSalesPerson)salesman;
        //        //(to) from
        //        //casting
        //        retailSalesPerson.Sell();
        //    }
        //    if (salesman is InsuranceBroker)
        //    {
        //        InsuranceBroker insuranceBroker = (InsuranceBroker)salesman;
        //        //(to) from
        //        //castings
        //        retailSalesPerson.Sell();
        //    }
        //}

        static void Main(string[] args)
        {
            List<Salesman> salesman = new List<Salesman>() { new CarSalesman2("One", "Two", 4), new RetailSalesman("Three", "Four"), new InsuranceBroker("Five", "Six") };

            foreach (var item in salesman)
            {
                showMeHowTOSell(item);
            }
        }

        static void showMeHowTOSell(Object salesman)
        {
            if (salesman is CarSalesman2)
            {
                CarSalesman2 carSalesman = (CarSalesman2)salesman;
                //(to) from
                //casting
                carSalesman.Sell();
            }
            if (salesman is RetailSalesman)
            {
                RetailSalesman retailSalesPerson = (RetailSalesman)salesman;
                //(to) from
                //casting
                retailSalesPerson.Sell();
            }
            if (salesman is InsuranceBroker)
            {
                InsuranceBroker insuranceBroker = (InsuranceBroker)salesman;
                //(to) from
                //casting
                insuranceBroker.Sell();
            }
        }
    }

}