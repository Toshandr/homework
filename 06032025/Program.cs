namespace _06032025;

public class People{
    public string Name{get;set;}
    public int Age{get;set;}

    public People(string name, int age){
        Name = name;
        Age = age;
    }
}

class Program
{
    static void Main(string[] args)
    {
        People people1 = new People("Anton", 17);
        People peplenew = new People("Aleha", 17);
        People people2 = new People("Oguzok", 18);
        People people3 = new People("Fedya", 14);
        People people4 = new People("Kolya", 0);
        List<People> spisok = new List<People>{people1,people2,people3,people4, peplenew};
        var newList = spisok.GroupBy(n => n.Age).Select(n => $"Age {n.Key}: {string.Join(", " , n.Select(j => j.Name))}");
        Console.WriteLine(string.Join("\n", newList));
        
    }
}
