namespace exc33;

class Program
{
    static void Main(string[] args)
    {
        Chet();
        
    }

    public static void Chet(){
        int a = Convert.ToInt32(Console.ReadLine());
        if(a % 2 == 0){
            Console.WriteLine("true");
        }
        else{
            Console.WriteLine("false");
        }
    }
}
