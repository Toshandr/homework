namespace u;

class Program
{
    static void Main(string[] args)
    {
        int[] spisok = {1,2,3,4,5};
        int k = 0;
        foreach(int i in spisok){
            k += i;
        }
        Console.WriteLine(k);
    }
}
