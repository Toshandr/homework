namespace u2;

class Program
{
    static void Main(string[] args)
    {
        int[] spisok = {1,2,3,4,100,5};
        int k = 0;
        foreach(int i in spisok){
            if (i > k){
                k = i;
            }
        }
        Console.WriteLine(k);
        
    }
}
