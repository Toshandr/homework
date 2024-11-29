namespace u7;

class Program
{
    static void Main(string[] args)
    {
        int[] spisok = {1,2,3,4,5,6,7,8,9,1000,11};
        int max = spisok[0];
        int min = spisok[0];
        foreach(int i in spisok){
            if (i > max){
                max = i; 
            }
            if (i < min){
                min = i;
            }
        }
        Console.WriteLine($"{max} {min}");
    }
}
