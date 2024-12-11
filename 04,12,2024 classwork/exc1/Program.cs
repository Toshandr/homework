namespace exc1;

class Program
{
    static void Main(string[] args)
    {
        Hello();
    }

    public static void Hello(){
        string name = Console.ReadLine();
        Console.WriteLine("Hello " + name);
    }
}
