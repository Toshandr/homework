namespace exc1;

class Program
{
    static void Main(string[] args)
    {
        int col = 0;
        int num = 0;
        int sum = 0;
        int[] numbers = {1,2,2,2,3,4,5,100,100,100,100};
        foreach(int i in numbers){
            sum = 0;
            for(int j=0; j < numbers.Length; j++){
                if(i == numbers[j]){
                    sum += 1;
                }
                if(sum > col){
                    col = sum;
                    num = i;
                }
            }
        }
        Console.WriteLine($"Самое часто встречающиеся число в массиво: {num} \nКоличество раз: {col}");
    }
}
