using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldTutorial
{
    public class Dog : IDogWalker
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public string Breed { get; set; }

        public Dog(string Name, int Age, string Breed)
        {
            this.Name=Name;
            this.Age=Age;
            this.Breed=Breed;
        }


        public void Bark()
        {
            Console.WriteLine("Woof");
        }

        public void WalkToThePark()
        {
            Console.WriteLine("Walking to the Park");
        }

        public void WalkToTheCity()
        {
            Console.WriteLine("Woof3");
        }
    }
}
