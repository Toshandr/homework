namespace exc2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(fib(3));
    }

    static int fib(int n){
        if(n == 1){
            return 1;
        }
        return n + fib(n-1);
    }
}
