/*Step 1 - Create a base class called Animal with a virtual method 
    animalSound() that outputs: The animal makes a sound

Step 2 - Create two derived classes:
    Cat – override animalSound() to say:The cat says: meow
    Dog – override animalSound() to say:The dog says: bow wow

Step 3 - In the Main() method:
    Create one object each of Animal, Cat, and Dog, 
    but use the base class Animal as the reference type.

    Call animalSound() on each.*/




namespace Lab8;

class Animal
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}
