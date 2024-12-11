namespace exc1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Factorial(5));
    }

    public static int Factorial(int n){
        if(n == 0){
            return 0;
        }
        if(n == 1){
            return 1;
        }
            return n * Factorial(n-1);
    }
}
