namespace InheritanceLesson;

class Program
{
    static void Main(string[] args)
    {
        //Radio acradio = new Radio(false, "Sony");

        //TV myTv = new TV(true, "Panasonic");

        //acradio.TurnOn();

        //acradio.ListenRadio();

        //myTv.WatchingTv();

        Dog dog = new Dog("doug", 45);

        Console.WriteLine($"{dog.Name} is {dog.Age} years old.");

        dog.Play();
        dog.Eat();
        dog.MakeSound();

        Console.ReadKey();


    }
}

