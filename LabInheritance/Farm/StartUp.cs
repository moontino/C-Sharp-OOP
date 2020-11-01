using System;

namespace Farm
{
     public class StartUp
    {
        static void Main(string[] args)
        {
           Puppy dog = new Puppy();
            dog.Bark();
            dog.Eat();
            dog.Weep();
            Cat cat = new Cat();
            cat.Meow();
        }
    }
}

