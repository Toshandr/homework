namespace u4;

class Program
{
    static void Main(string[] args)
    {
        int[] spisok = {1,2,3,4,5,6,7};
        foreach (int i in spisok){
            if (i%2 == 0){
                Console.WriteLine(i);
            }
        }
    }
}
