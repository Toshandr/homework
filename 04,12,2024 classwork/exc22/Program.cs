namespace exc22;

class Program
{
    static void Main(string[] args)
    {
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Max(a,b));
    }

    public static int Max(int a, int b){
        if (a > b){
            return a;
        }
        if (b > a){
            return b;
        }
        else{
            return 0;
        }
    }

}