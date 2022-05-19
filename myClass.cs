
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment7
{
    internal class myPerson
    {
       private string _name;
       private string _surname;
       private int _age;


       private string _favouriteColor;
       private string _favouriteCar;

        public myPerson()
        {
            this._name = "Linathi";
            this._surname = "Mrulekana";
            this._age = 0;

            Console.WriteLine("");
        }
        public myPerson(string name, string surname, int age)
        {
            this._name = name;
            this._surname = surname;
            this._age = age;
            
        }
        public string Surname
        {
            get
            {
                return _surname;
            }

            set
            {
                _surname = value;
            }
        }
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string GetSurname()
        {
            return _surname;
        }

        public void SetSurname(string surname)
        {
            _surname = surname;
        }
        public string getColor()
        {
            return _favouriteColor;
        }
        public void setColor(string color)
        {
            _favouriteColor = color;
        }
        public string getCar()
        {
            return _favouriteCar;
        }
        public void setCar(string Car)
        {
            _favouriteCar = Car;    
        }
    }
}
