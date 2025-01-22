using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Propertyk használatára szolgál. A property egy változó, ami publikus. 
 * 
 * 
 * Két metódus: 
 -set érték beállításához
-get az érték visszaadásához
 */
namespace GetterSetter
{
    class Person
    {
        /* Alap deklaráció: property
           Itt nem ellenőrizzuk a beírást és a kiírást
         */
        public Person() { }

        public string Name { get; set; }
/*
 * Ha közvetlen hozzá akarunk férni:
 */
        private int id;
        public int Id { get => id; set => id = 101; }

        private int age;
        public void setAge(int age) { this.age = age; }
        public int getAge() { return this.age; }

        private int gender;
        public void setGender(string gender)
        {
            switch (gender)
            {
                case "Férfi": this.gender = 1; break;

                case "Nő": this.gender = 2; break;

                default: this.gender = 3; break;
            }
        }

        public string getGender()
        {
            switch (this.gender)
            {
                case 1: return "Férfi";
                case 2: return "Nő";
                default: return "Ismeretlen";
            }
        }
    }



    class GetterSetterProg
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "Ádám";
            Console.WriteLine(person.Name);

            person.Id = 99;
            Console.WriteLine(person.Id);

            Console.ReadKey();
        }
    }
}

