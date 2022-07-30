// Polymorphism - Taking many forms
// Abstraction - Data hiding. Abstract class can only be accessed from its shild

namespace Practice{
    public class Animals{   // Base Class
        public virtual void animalSound()
        {
            Console.WriteLine("This animal makes sound!");
        }
    }

    public class Dog : Animals {
        public override void animalSound()
        {
            Console.WriteLine("Bark, Bark!"); 
        }
    }

    public class Cow : Animals {
        public override void animalSound()
        {
            Console.WriteLine("Moo, Moo!");
        }
    }
}