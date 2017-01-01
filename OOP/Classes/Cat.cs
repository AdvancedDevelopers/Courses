using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Classes
{
    public class Cat:Animal
    {
        private string _Owner;
       public Cat(string name,string Owner,Genders gender) : base(name,gender)
        {
            Console.WriteLine("a New Cat is Created");
            this._Owner = Owner;
        }
        public override void Speak()
        {
            Console.WriteLine("my name is:"+Name+" my owner is:"+Owner+" i'm a:"+Gender);
        }
        public string Owner {
            get { return _Owner; }
            set { _Owner = value; }
        }
        public DateTime MyBirthdate { get { return Birthdate; } }
    }
}
