namespace massives;

class Program
{
    static void Main(string[] args)
    {
        int[,] mass = new int[5, 4];
        Random rand = new Random();

        for(int i = 0; i < mass.GetLength(0); i++){
            for(int j = 0; j < mass.GetLength(1); j++){
                int number = rand.Next(0,11);
                mass[i,j] = number;
                Console.Write(mass[i,j] + " ");
            }
            Console.WriteLine(" ");
        }
    }
}
