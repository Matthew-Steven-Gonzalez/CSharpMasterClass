namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car audi = new Car("Audi A4", 200);
            audi.Drive();
            Car bmw = new Car("BMW M5", 350);
            Console.WriteLine("Press 1 to stop the car.");
            string userInput = Console.ReadLine();
            if(userInput == "1")
            {
                audi.Stop();
            }
            else
            {
                Console.WriteLine("car keeps going.");
            }
            bmw.CarInfo();
            audi.CarInfo();

            Console.Read();
        }
    }
}