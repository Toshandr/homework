namespace exc0;

class Program
{
    static void Main(string[] args)
    {
        int request = Convert.ToInt32(Console.ReadLine());
        int maxSum = 0;
        int[] numbers = {1,2,3,4,5,6,7,100};
        for(int i = 0; i < numbers.Length - request; i++){
            int sum = 0;
            for(int j = 0; j <= request; j++){
                sum += numbers[i+j];
            }
            if(sum >= maxSum){
                maxSum = sum;
            }
        }
        Console.WriteLine(maxSum);
    }
}
