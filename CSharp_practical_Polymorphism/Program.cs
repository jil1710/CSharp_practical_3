class Bird
{
    public void Voice()
    {
        Console.WriteLine("Turr Turr!");
    }
}

class Duck : Bird
{
    public void Voice()
    {
        Console.WriteLine("Quack Quack!");
    }

    public static void Main(string[] args)
    {
        Bird bird = new Bird();
        Duck duck = new Duck();
        bird.Voice(); // Output: Turr Turr!
        duck.Voice(); // Output: Quack Quack!
        Console.ReadKey();  
    }
}