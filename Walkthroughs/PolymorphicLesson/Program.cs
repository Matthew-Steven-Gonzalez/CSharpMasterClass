namespace PolymorphicLesson;

class Program
{
    static void Main(string[] args)
    {

        var cars = new List<Car>
        {
            new Audi("blue", 500, "s500"),
            new BMW ("red", 400, "M3")

           
        };
    }
}

