namespace exc3b;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers1 = {1,100,2,101,3,102};
        int[] numbers2 = {1,100,4,103,3,111};
        int[] ans = new int{numbers1.Length + numbers2.Length};
        Array.Sort(numbers1);
        Array.Sort(numbers2);
        for(int i = 0; i < numbers1.Length; i++){
            for(int j = 0; j < numbers2.Length;j++){
                if(numbers1[i] == numbers1[j]);
                ans.CopyTo(numbers1[i], 1);
            }
        }
    }
}
