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

    public virtual void AnimalSound1()
    {
        Console.WriteLine("The animal makes a sound");
    }

    public virtual void AnimalSound2()
    {
        Console.WriteLine("The animal makes a sound");
    }
}
/*Step 2 - Create two derived classes:
    Cat – override animalSound() to say:The cat says: meow
    Dog – override animalSound() to say:The dog says: bow wow*/

public class Cat : Animal
{
    public override void AnimalSound2()
    {
        Console.WriteLine("The cat says: meow");
    }
}

public class Dog : Animal
{
    public override void AnimalSound2()
    {
        Console.WriteLine("The dog says: bow wow");
    }
}


/*Step 3: In the Main() method:
Create one object each of Animal, Cat, and Dog, but use the base class Animal as the reference type.
Call animalSound() on each.*/
public class Animal1
{
    public virtual void AnimalSound1()
    {
        Console.WriteLine("The animal makes a sound");
    }
}

public class Cat1 : Animal
{
    public override void AnimalSound1()
    {
        Console.WriteLine("The cat says: meow");
    }
}

public class Dog1 : Animal
{
    public override void AnimalSound1()
    {
        Console.WriteLine("The dog says: bow wow");
    }
}

public class Program
{
    public static void Main()
    {
        Animal myAnimal = new Animal();
        Animal myCat = new Cat1();
        Animal myDog = new Dog1();

        myAnimal.AnimalSound();  
        myCat.AnimalSound();    
        myDog.AnimalSound();
    }
}
