namespace _05032025;

class Program
{
    static void Main(string[] args)
    {
        /*List<int> numbers = new List<int> { 1, 3, 5, 7, 9, 2, 4, 6, 8 };
        var newMass = numbers.OrderByDescending(n => n).Where(n => n>numbers.Average());
        Console.WriteLine(string.Join(" ", newMass));*/
        /*List<string> words = new List<string> { "cat", "dog", "elephant", "tiger", "bear" };
        var ansWords = words.Where(n => n.Length > 3).Select(n=>n.ToUpper());

        Console.WriteLine(string.Join(" ", ansWords));*/

        /*List<int> numbers = new List<int> { 1, 3, 5, 3, 7, 9, 1, 2, 4, 6, 8 };
        var newNum = numbers.Distinct().OrderByDescending(n => n);
        Console.WriteLine(string.Join(" ", newNum));*/

        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        var newNumb = numbers.Where(n=>n%2==0&&n>5).Sum();
        Console.WriteLine(newNumb).To;


    }
}
