namespace exc_1;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = {1,2,34,5,2,2,2};
        Array.Sort(numbers);
        int ans = 0;
        for (int i = 0; i < numbers.Length-1; i++){
            if (numbers[i] != numbers[i+1]){
                ans += 1;
            }
        }
        Console.WriteLine(ans);

    }
}
