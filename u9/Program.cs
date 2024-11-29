namespace u9;

class Program
{
    static void Main(string[] args){
        int[] spisok = {1,-2,-3,4,5,-6,-7};
        for(int i = 0; i < spisok.Length; i++){
            if (spisok[i] < 0){
                spisok[i] = 0;
            }
        }
        foreach(int i in spisok){
            Console.WriteLine(i);
        }
    }
}
