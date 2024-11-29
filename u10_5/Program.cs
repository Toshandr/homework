namespace u10_5;

class Program
{
    static void Main(string[] args)
    {
        int[] spisok = {1,-2,-3,4,5,-6,-7};
        for(int i = 0; i < spisok.Length; i++){
            if (spisok[i] < 0){
                Console.WriteLine(spisok[i]);
                }
        }
    }
}
