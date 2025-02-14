using System;
using System.Linq;



namespace _14022025;

class Employee{
    public string Name;
    public int Zp;

    public Employee(string name, int zp){
        Name = name;
        Zp = zp;
    }
}

class Program
{
    static void Main(string[] args)
    {
        //Практика A1
        List<int> sp = new List<int>{1,2,3,4,5};
        int k = 0;
        foreach(int i in sp){
            Console.Write(i + " ");
            k+=i;
        }
        Console.WriteLine();
        Console.WriteLine(k);

        //Практика A2
        Dictionary<string, List<int>> dict = new Dictionary<string, List<int>>{
            {"Митяев", new List<int> {3,4,5}}, 
            {"Дроздов", new List<int> {3,2,5}},
            {"Иванчиков", new List<int> {3,3,5}}
        };
        double srb = 0;

        foreach (string i in dict.Keys){
            srb = dict[i].Average();
            Console.WriteLine($"ср.балл: {srb}");
        }


        //Практика B1
        List<string> alph = new List<string>{"Ab", "Za", "Rb"};
        alph.Sort();
        foreach(string i in alph){
            Console.Write(i + " ");
        }
        Console.WriteLine();

        //Практика B2-3
        Dictionary<string, int> products = new Dictionary<string, int>{
            {"Арбузы", 5}, 
            {"Томаты", 6},
            {"Яблоки", 0}
        };

        foreach (string i in products.Keys){
            products[i]+=1;
            Console.WriteLine($"{i} количество {products[i]}");
        }


        //пркатика С
        Employee empl1 = new Employee("Сеня", 30000);
        Employee empl2 = new Employee("Федя", 40000);
        Employee empl3 = new Employee("Артурчик", 15000);

        List<int> SpisokZp = new List<int>{};
        SpisokZp.Add(empl1.Zp);
        SpisokZp.Add(empl2.Zp);
        SpisokZp.Add(empl3.Zp);

        SpisokZp.Sort();
        SpisokZp.Reverse();
        foreach(int i in SpisokZp){
            Console.WriteLine($"зп: {i}");
        }
        



        /*
        Queue<string> queue = new Queue<string>();
        queue.Enqueue("First");
        queue.Enqueue("Sec");
        string item = queue.Dequeue();
        Console.WriteLine(item);


        Stack<string> stack = new Stack<string>();
        stack.Push("First");
        string Item = stack.Pop(); */

    }
}
