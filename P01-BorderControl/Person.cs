using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_BorderControl
{
    public class Person : Humanoid
    {
        public string Name { get; set; }
        public string Age { get; set; }
        public Person(string name, string age, string id) 
        : base(id)
        {
            this.Name = name;
            this.Age = age;
        } 
    }
}
