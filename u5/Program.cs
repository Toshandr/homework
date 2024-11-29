namespace u5;

class Program
{
    static void Main(string[] args)
    {
        int[] spisok = {1,2,3,4,5,6,7};
        int zapros;
        zapros = Convert.ToInt32(Console.ReadLine());
        foreach (int i in spisok){
            if (i==zapros){
                Console.WriteLine(i);
                break;
            }
            else{
                continue;
            }
        }
    }
}