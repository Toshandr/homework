namespace exc3;

class Program
{
    static void Main(string[] args)
    {
        string stroka = "12345";
        Console.WriteLine(reverseStr(stroka));
    }

    static string reverseStr(string a){
        if(a.Length <= 0) return "";
        return a[a.Length - 1] + reverseStr(a, a.Length - 1); //да я чёт вообще не врубаю рекурсию со строками
    }
}
