using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP.Classes;
namespace OOP
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Cat mycat = new Classes.Cat("simba", "Ismail",Genders.Male);
            mycat.YourName();
            mycat.Speak();
            Console.WriteLine("my birthdate is: " + mycat.MyBirthdate);
            Calc.x = 15;
            Calc.y = 5;
            Console.WriteLine(Calc.division());
            Console.WriteLine(Calc.Sum());
            Console.WriteLine(Calc.substraction());
            Console.WriteLine(Calc.Multipe());
            AccessModifiers newSample = new AccessModifiers("i'm Testing Code");
            Console.WriteLine("Access Modifiers Name: "+ newSample.MyName);
            Food newFood = new OOP.Program.Food();
            newFood.wieght = 1000;
            newFood.expires = DateTime.Now;
            
        }
        struct Food
        {
            public float wieght;
            public DateTime expires;
        }
    }
}
