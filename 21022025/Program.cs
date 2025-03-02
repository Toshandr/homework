namespace _21022025;

class Program
{
    static void Main(string[] args)
    {
        string path = "ll.txt";
        try{
            string data = File.ReadAllText(path);
        }
        catch(Exception ex){
            Console.WriteLine(ex.Message);
        }
        Console.Write("ДДДДДДД");
    }
}
