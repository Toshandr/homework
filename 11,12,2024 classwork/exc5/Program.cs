namespace exc5;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(nod(2,6));
    }
    static int nod(int a, int b){
        if(b == 0) return a;
        return nod(b, a%b);
    }
}
