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

        //Dog dog = new Dog("doug", 45);

        //Console.WriteLine($"{dog.Name} is {dog.Age} years old.");

        //dog.Play();
        //dog.Eat();
        //dog.MakeSound();

        Post post1 = new Post("Thank you very much", true, "Jimbob");

        ImagePost imagepost1 = new ImagePost("Check out my new shoes", "JimBob", true, "Https//images.com/shoes");

        VideoPost videoPost1 = new VideoPost("BasketBall game", "DougJones", true, "Https//youtube.com/fjdwjfuucedn", 8);

        Console.WriteLine(post1.ToString());

        Console.WriteLine(imagepost1.ToString());

        Console.WriteLine(videoPost1.ToString());

        videoPost1.Play();


        Console.WriteLine("press any key to stop video.");
        Console.ReadKey();
        videoPost1.Stop();


        Console.ReadKey();

    }
}

