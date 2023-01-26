namespace testapp;
class Program
{
    static void Main(string[] args)
    {
        string username = "User";
        
        Console.WriteLine($"enter your name");
        username = Console.ReadLine();
        Console.WriteLine($"Hello, {username}!");
        Console.ReadKey(true);
    }
}
