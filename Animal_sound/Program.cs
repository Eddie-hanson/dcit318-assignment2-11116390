using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_sound
{
    internal class Program
    {
        class Animal
        {
            public virtual void MakeSound()
            {
                Console.WriteLine("Some generic sound");
            }
        }

        class Dog : Animal
        {
            public override void MakeSound()
            {
                Console.WriteLine("Bark");
            }
        }
        class Cat : Animal
        {
            public override void MakeSound()
            {
                Console.WriteLine("Meow");
            }
        }
        static void Main(string[] args)
        {
           
            Animal genericAnimal = new Animal();
            Dog dog = new Dog();
            Cat cat = new Cat();

            genericAnimal.MakeSound(); 
            dog.MakeSound();           
            cat.MakeSound();           

            
            Animal myDog = new Dog();
            Animal myCat = new Cat();

            myDog.MakeSound();       
            myCat.MakeSound();         
        }
    }
}
