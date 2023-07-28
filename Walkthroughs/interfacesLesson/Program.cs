namespace interfacesLesson;

class Program
{
    static void Main(string[] args)
    {

        Ticket t1 = new Ticket(10);

        Ticket t2 = new Ticket(7);

        Console.WriteLine(t2.Equals(t1));

        Chair officeChair = new Chair("Brown", "plastic");

        Chair gamingChair = new Chair("White", "Leather");

        Car damagedCar = new Car(80f, "blue");

        damagedCar.DestroyablesNearby.Add(officeChair);
        damagedCar.DestroyablesNearby.Add(gamingChair);

        damagedCar.Destroy();


        Console.ReadKey();
    }
}

