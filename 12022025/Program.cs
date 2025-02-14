namespace _12022025;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, List<int>> dict = new Dictionary<string, List<int>>{
            {"Иванов", new List<int> {2,2,2,3,4,5}}, 
            {"Петров", new List<int> {2,2,2,3,2,5}},
            {"Сидоров", new List<int> {2,2,2,3,3,5}}
        };
        Console.WriteLine(dict["Иванов"]);

        foreach (string i in dict.Keys){
            Console.WriteLine(i + " " + dict[i]);
        }
    }
}
