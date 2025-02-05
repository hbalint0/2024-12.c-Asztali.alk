using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property
{
    
    class Person
    {
        //Tagváltozók
        string name; //Osztályváltozó
        //Property
        public string Name { get; set; }
        //Konstruktor
        public Person() { }
        //Setter getter metódusok a name tagváltozóhoz
        public void SetName(string name)
        {
            this.name = name;
        }
        public string GetName()
        {
            return this.name;
        }

    }
}
