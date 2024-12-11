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
        return reverseStr(a.Substring(1)) + a[0] ; //да я чёт вообще не врубаю рекурсию со строками
    }
}
