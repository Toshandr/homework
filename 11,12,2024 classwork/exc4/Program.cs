namespace exc4;

class Program
{
    static void Main(string[] args)
    {
        int[] num = {1,2,3,4,5};
        Console.WriteLine(sum(num));
    }

    static int sum(int[] mass, int ind = 0){
        if (ind >= mass.Length){
            return 0;
        }
        return sum(mass, ind + 1) + mass[ind];
    }
}
