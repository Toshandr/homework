namespace u8;

class Program
{
    static void Main(string[] args)
    {
        int[] spisok = {1,3,2,6,4,7,5};
        Array.Sort(spisok);
        foreach (int i in spisok){
            Console.WriteLine(i);
        }
    }
}
