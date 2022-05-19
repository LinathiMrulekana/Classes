using System;

namespace assignment7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            myPerson info = new myPerson("Afikile", "Mkiva", 18);
            info.setColor("Red");
            info.setCar("Ford");

            Console.WriteLine("Name: " + info.Name);
            Console.WriteLine("Surname: " + info.Surname);
            Console.WriteLine("Age: "+ info.Age);
            Console.WriteLine("Color: "+ info.getColor());
            Console.WriteLine("Car: "+ info.getCar());

        }
    }
}
       
   

