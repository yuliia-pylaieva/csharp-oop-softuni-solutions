using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace Farm
{
    public static class StartUp
    {
        public static void Main()
        {
            Puppy puppy = new Puppy();
            puppy.Eat();
            puppy.Bark();
            puppy.Weep();
            
            Dog dog = new Dog();
            dog.Eat();
            dog.Bark();


            Cat cat = new Cat();
            cat.Eat();
            cat.Meow();

        }

    }
}

