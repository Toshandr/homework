namespace _26022025;

class Program
{
    static void Main(string[] args)
    {
        string[] strings = {"afafas", "aa", "aaaa", "a", "b", "aaaaaaa"};
        //var new_strings = strings.Where(n => n.Length >= 3);
        //Console.WriteLine(string.Join(" ", new_strings));
        var new_striinig = strings.Select(n => "!"+n+"!");
        Console.WriteLine(string.Join(" ", new_striinigs));

        int[] numbers = {1,2,3,4,5,6,7,8,9};
        var num = numbers.GroupBy<>;
    }
}
