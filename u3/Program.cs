namespace u3;

class Program
{
    static void Main(string[] args)
    {
        int[] spisok = {1,2,3,4,5,6,7};
        Array.Reverse(spisok);
        foreach (int i in spisok){
            Console.WriteLine(i);
        }
    }
}
