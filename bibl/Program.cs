namespace bibl;

abstract class Item{
    private bool Status;
    private string Sost;
    public string Author;
    public string Title;

    public Item( string author, string title){
        Author = author;
        Title = title;
    }
    public virtual void DisplayInfo(){}

    public void Status_display(){
        Console.WriteLine(Status);
    }

    public void Sost_display(){
        Console.WriteLine(Sost);
    }

    public void Status_Change(){
        Console.WriteLine("Введите логическое значение наличие или отсутсвие товара true/false соответсвенно");
        Status = Convert.ToBoolean(Console.ReadLine());
    }
    public void Sost_Change(){
        Console.WriteLine("Введите состяние товара: New, Used, Damaged");
        Sost = Console.ReadLine();
    }
}

class Book : Item{

    public Book(string author, string title) : base(author, title){};

    public void Read(){
        Console.WriteLine("Reading");
    }
    public override void DisplayInfo()
    {
        Console.WriteLine($"{Title}, {Author}");
    }
}

class Magazine : Item{
    public Magazine(string author, string title) : base(author, title){};

    public void FlipThrough(){
        Console.WriteLine("Listayu");
    }
    public override void DisplayInfo()
    {
        Console.WriteLine($"{Title}, {Author}");
    }
}

class DVD : Item{
    public DVD(string author, string title) : base(author, title,){};

    public void Play(){
        Console.WriteLine("Listening");
    }
    public override void DisplayInfo()
    {
        Console.WriteLine($"{Title}, {Author}");
    }
}



class Program
{
    static void Main(string[] args)
    {
        Book book1 = new Book("Портрет Дориана Грея", "Оскар Уайльд");
        Magazine magazine1 = new Magazine("Forbes", "американец");
        DVD disk1 = new DVD("Need for Speed MostWanted", "американец/мексиканец");
        List<Item> items = new List<Item>{};
        items.Add(book1);
        items.Add(magazine1);
        items.Add(disk1);
        foreach(Item m in items){
            m.DisplayInfo();
        }
        book1.Sost_Change();
        book1.Sost_display();
    }
}
