namespace Lab8;

/*Step 1 - Create a base class called Animal with a virtual method 
    animalSound() that outputs: The animal makes a sound*/

using System;
public class Animal
{
    public virtual void AnimalSound()
    {
        Console.WriteLine("The animal makes a sound");
    }
}
public class Dog : Animal
{
    public override void AnimalSound()
    {
        Console.WriteLine("The dog barks");
    }
}

public class Program
{
    public static void Main()
    {
        Animal myAnimal = new Animal();
        Animal myDog = new Dog();

        myAnimal.AnimalSound();
        myDog.AnimalSound();  
    }
}




