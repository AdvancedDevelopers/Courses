using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Classes
{
    public class Animal
    {
        private string _name;
        private Genders _gender;
        protected DateTime Birthdate;
        public Animal(string name,Genders gender)
        {
            Console.WriteLine("a New Animal is Created");
            this._name = name;
            this._gender = gender;
            this.Birthdate = DateTime.Now;
        }
        public virtual void Speak()
        {
            Console.WriteLine("I'm Animal , i don't know how to speak");
            
        }
        public void YourName()
        {
            Console.WriteLine("my Name is:" + Name);
        }
        public string Name {
            get { return _name; }
            set { _name = value; }
        }
        public Genders Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }
    }
}
