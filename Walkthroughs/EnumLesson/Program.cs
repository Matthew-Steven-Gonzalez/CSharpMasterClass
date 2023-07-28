using System.Collections;
using System.Collections.Generic;

namespace EnumLesson;

class Program
{
    static void Main(string[] args)
    {
        //DogShelter shelter = new DogShelter();

        //foreach(Dog dog in shelter)
        //{
        //    if(!dog.IsNaughtyDog)
        //    {
        //        dog.GiveTreat(2);
        //    }
        //    else
        //    {
        //        dog.GiveTreat(1);
        //    }

        //}
        IEnumerable<int> unknownCollection;

        unknownCollection = GetCollection(3);

        Console.WriteLine("This was a list.");

        foreach(int num in unknownCollection)
        {
            Console.WriteLine(num + " ");
        }
        Console.ReadKey();

    }

    static IEnumerable<int> GetCollection(int option)
    {
        //create a list
        List<int> numbersList = new List<int>() { 1, 2, 3, 4, 5 };

        //create que and add values
        Queue<int> numbersQue = new Queue<int>();
        numbersQue.Enqueue(6);
        numbersQue.Enqueue(7);
        numbersQue.Enqueue(8);
        numbersQue.Enqueue(9);
        numbersQue.Enqueue(10);

        if(option == 1)
        {
            return numbersList;
        }
        else if(option ==2)
        {
            return numbersQue;
        }
        else
        {
            return new int[] { 11,12,13,14,15};
        }

    }

    //class of dog 
    //class Dog
    //{
    //    public String Name { get; set; }

    //    public bool IsNaughtyDog { get; set; }

    //    public Dog(string name, bool isNaughtyDog)
    //    {
    //        this.Name = name;
    //        this.IsNaughtyDog = isNaughtyDog;
    //    }

    //    public void GiveTreat(int numberOfTreats)
    //    {
    //        Console.WriteLine($"Dog {Name} said wuoff {numberOfTreats} times!");
    //    }
    //}

    //class that uses a list of dogs 
    //class DogShelter : IEnumerable<Dog>
    //{
    //    public List<Dog> dogs;


    //    public DogShelter()
    //    {
    //        dogs = new List<Dog>(){
    //            new Dog("Casper", false),
    //            new Dog("Juni", true),
    //            new Dog("khaluna", false),
    //            new Dog("Oreo", true)
    //        };
    //    }

    //    IEnumerator<Dog> IEnumerable<Dog>.GetEnumerator()
    //    {
    //        return dogs.GetEnumerator();
    //    }

    //    IEnumerator IEnumerable.GetEnumerator()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
}

