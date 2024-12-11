namespace exc2;

class Program
{
    static void Main(string[] args){
        int[,] doubleMass1 = new int[3,5];
	    int[,] doubleMass2 = new int[doubleMass1.GetLength(1),doubleMass1.GetLength(0)];
        Console.WriteLine("Изначальный массив:");
	    for(int i = 0; i < doubleMass1.GetLength(0); i++){
	        for(int j = 0; j < doubleMass1.GetLength(1); j++){
	            Console.Write(doubleMass1[i,j]);
	        }
	        Console.WriteLine("");
	    }

	    Console.WriteLine("Конечный массив:");
	    for(int i = 0; i < doubleMass2.GetLength(0); i++){
	        for(int j = 0; j < doubleMass2.GetLength(1); j++){
	            Console.Write(doubleMass2[i,j]);
	        }
	        Console.WriteLine("");
	    }   
	    Console.WriteLine("Транспортиризация двумерного массива завершена");
	    Console.ReadKey();
    }
}
