namespace exc2;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = {1,2,3,4,5,6,7,2,10,2,5};
        int col1 = 0;
        string unic1 = "";
        Array.Sort(numbers);
        for(int i = 0; i < numbers.Length-1; i++){
            int col2 = 0;
            int unic2 = 0;
            if(numbers[i] == numbers[i+1]){
                col2 += 1;
            }
        }
    }
}
