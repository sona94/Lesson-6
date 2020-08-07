using System;

namespace OOP_concept
{
    class Program
    {
        //string color = "red";
        static void Main(string[] args)
        {
            // Examples of creating objects and Classes

            /*Console.WriteLine("Hello World!");
             Program myobj = new Program();
             Program myobj2 = new Program();
            Console.WriteLine(myobj2.color);
            Car myobj = new Car();
            Console.WriteLine(myobj.color); */
            CoffeeMug mug1 = new CoffeeMug("white", "black", "World's Best Daddy", 16);
            CoffeeMug mug2 = new CoffeeMug("black", "gold", "Rise & Shine", 12);

            mug1.Fill();
            mug1.Drink();
            mug1.Drink();
            mug1.Fill();
            mug1.Fill();
            mug1.Drink();

            Animal animal1 = new Animal(4, 0, "Cat", "Snowball", true);
            Animal animal2 = new Animal(8, 0, "Spider", "Friendly the Spider", false);
            Animal animal3 = new Animal(2, 2, "Monkey", "Bobo", false);

            animal1.ShowDetails();
            animal3.ShowDetails();

            animal1.SendToObedienceSchool();
            animal2.SendToObedienceSchool();

            animal2.Evolve(2, 12);
            animal2.ShowDetails();
            




        }
    }
}
