namespace u6;

class Program
{
    static void Main(string[] args)
    {
        int[] spisok = {1,2,3,4,5,6,7};
        for(int i = 0; i < spisok.Length; i++){
            if (i%2 == 0){
                Console.WriteLine(spisok[i]);
            }
        }
    }
}