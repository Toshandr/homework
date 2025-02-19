namespace _19022025;



class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        //Практика 1
        Dictionary<string, int> mapl = new Dictionary<string, int>{
            {"1", 1},
            {"2", 2},
            {"3", 3}
        };
        try{
            Console.WriteLine(mapl["5"]);
        }
        catch(Exception ex){
            Console.WriteLine(ex.Message);
        }
        finally{
            Console.WriteLine("Продолжение задания 1...");
        }

        //Практика 2
        int a = 10;
        int b = 0;
        try{
            Console.WriteLine(a/b);
        }
        catch(Exception ex){
            Console.WriteLine(ex.Message);
        }
        finally{
            Console.WriteLine("Продолжения задачи 2...");
        }

        //Практика 3
        try{
            Console.Write("Введите число: ");
            int l = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
        }
        catch(FormatException ex){
            Console.WriteLine("Вы ввели не число! " + ex.Message);
        }
        catch(OverflowException ex){
            Console.WriteLine("Число слишком большое" + ex.Message);
        }

        
    

  

    }
}
