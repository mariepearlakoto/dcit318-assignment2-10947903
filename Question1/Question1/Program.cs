using System;

public class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Some generic sound");
    }
}

public class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Bark");
    }
}

public class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Meow");
    }
}


class Program
{
    static void Main(string[] args)
    {
        Animal animal1 = new Animal();
        Dog dog1 = new Dog();
        Cat cat1 = new Cat();

        animal1.MakeSound();
        dog1.MakeSound();
        cat1.MakeSound();
    }
}
