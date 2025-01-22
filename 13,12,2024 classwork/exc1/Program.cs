namespace exc1;

class Program
{
    static void Main(string[] args)
    {
        int param1 = Convert.ToInt32(Console.ReadLine());
        int param2 = Convert.ToInt32(Console.ReadLine());
        string param3 = Console.ReadLine();
        posled(param1, param2, param3);
    }

    public static void posled(int a, int b, string c){
        for(int i = a; i <= b; i++){
            if(c == "true"){
                if(i%2 == 0){
                    Console.Write(i + " ");
                }
            }
            if(c == "false"){
                if(i%2!=0){
                    Console.Write(i + " ");
                }
            }  
        }
    }
}
