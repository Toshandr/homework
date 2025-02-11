namespace bibl;

class Library{
    private List<Item> Collections;

    public Library(List<Item> coll){
        Collections = coll;
    }

    public void Add(){
        Console.WriteLine("Введите какой товар вы хотите добавит DVD/Magazine/Book");
        string ch1 = Console.ReadLine();
        while(ch1 != "DVD" && ch1 != "Magazine" && ch1 != "Book"){
            Console.WriteLine("Введите корректное название товара");
            ch1 = Console.ReadLine();
        }
        switch (ch1){
            case "DVD":
                /*создаём новый объект подкласса DVD с ИНДИВИДУАЛЬНЫМ НАЗВАНИЕМ ОБЪЕКТА:
                1. Создаём новое название обЪекту
                2. Проверяем что объекта с таким именем ещё нет
                3. Если такого нет, то просим ввести Названия и Автора
                4. Заводим для это 2 переменные
                5. Создаём новый обЪект
                6. с помощью метода Add добавляем объект в колекцию. Так как коллекция имеет тип Item, то тогда и только тогда мы сможем добавит новый элемент
                (Collections.Add(название нового объект);)
                */
                break;
            
            case "Magazine":
                /*создаём новый объект подкласса Magazine с ИНДИВИДУАЛЬНЫМ НАЗВАНИЕМ ОБЪЕКТА:
                1. Создаём новое название обЪекту
                2. Проверяем что объекта с таким именем ещё нет
                3. Если такого нет, то просим ввести Названия и Автора
                4. Заводим для это 2 переменные
                5. Создаём новый обЪект
                6. с помощью метода Add добавляем объект в колекцию. Так как коллекция имеет тип Item, то тогда и только тогда мы сможем добавит новый элемент
                (Collections.Add(название нового объект);)
                */
                break;
            
            case "Book":
                /*создаём новый объект подкласса Book с ИНДИВИДУАЛЬНЫМ НАЗВАНИЕМ ОБЪЕКТА:
                1. Создаём новое название обЪекту
                2. Проверяем что объекта с таким именем ещё нет
                3. Если такого нет, то просим ввести Названия и Автора
                4. Заводим для это 2 переменные
                5. Создаём новый обЪект
                6. с помощью метода Add добавляем объект в колекцию. Так как коллекция имеет тип Item, то тогда и только тогда мы сможем добавит новый элемент
                (Collections.Add(название нового объект);)
                */
                break;
        }
    }
    public void Remove(){ //метод удаления(на занятии объясню если что как работает, время 0:24, поэтому мне уже чуть-чуть лень расписывать)
        Console.Write("Введите название объекта который вы хотите удалить: ");
        string ans = Console.ReadLine();
        int k = 0;
        foreach (Item it in Collections)
        {
            if (ans != it.Author){
                k++;
            }
            if (ans == it.Author){
                Console.WriteLine("Операция вполнена");
                Collections.Remove(it);
            }
            if (k == Collections.Count){
                Console.WriteLine("Такого объекта нет");
            }
        }
    }
    public void Find(){ // метод поиска
        Console.WriteLine("Введите название объекта который вы хотите найти");
        string ans = Console.ReadLine();
        int k = 0;
        foreach (Item it in Collections)
        {
            if (ans != it.Author){
                k++;
            }
            if (ans == it.Author){
                Console.WriteLine("Такой объект есть");
                Console.WriteLine(it.Author, it.Title);
            }
            if (k == Collections.Count){
                Console.WriteLine("Такого объекта нет");
            }
        }
    }
    public void DisplayAllItems(){ // метод просмотра всей коллекции
        int k = 1;
        foreach(Item it in Collections){
            Console.WriteLine($"{k}. Название: {it.Title}, Автор: {it.Author}");
            k++;
        }
    }
}



abstract class Item{ //Родительский класс Item
    private bool Status; //4 поля отвечающие за статус, состояние, автора, название продукта(2 приватных которые можно изменять только внутри класс)
    private string Sost;
    public string Author;
    public string Title;

    public Item( string author, string title){ //конструктор класса (придаём значения полям класса)
        Author = author;
        Title = title;
    }
    public virtual void DisplayInfo(){} //первый метод который мы будем изменять в подклассах

    public void Status_display(){ //второй метод, благодаря которому будем отслеживать статус предмета(в наличие/не в наличие)
        Console.WriteLine(Status);
    }

    public void Sost_display(){ //третий метод, благодаря которому будем мониторить состояние товара
        Console.WriteLine(Sost);
    }

    public void Status_Change(){ // метод изменения статуса с проверкой
        Console.WriteLine("Введите логическое значение наличие или отсутсвие товара true/false соответсвенно");
        Status = Convert.ToBoolean(Console.ReadLine()); //хочу сделать проверку здесь но из за преоброзваний string => boolean чуть-чуть не понимаю
        while(Status != true && Status != false){
            Console.WriteLine("Введите корректную информацию о наличии товара");
            Status = Convert.ToBoolean(Console.ReadLine());
        }
    }
    public void Sost_Change(){ // метод изменения состояния с проверкой
        Console.WriteLine("Введите состяние товара: New, Used, Damaged");
        Sost = Console.ReadLine();
        while(Sost != "New" && Sost != "Used" && Sost != "Damaged"){
            Console.WriteLine("Введите корректную информацию о состоянии товара");
            Sost = Console.ReadLine();
        }
    }
    public void Borrow(){
        Status = false;
    }
    public void Return(){
        Status = true;
    }
}

class Book : Item{// первый подкласс Book

    public Book(string author, string title) : base(author, title){} // конструктор

    public void Read(){ //метод1
        Console.WriteLine("Reading");
    }
    public override void DisplayInfo() //метод для просмотря названия и автора
    {
        Console.WriteLine($"{Title}, {Author}");
    }
}

class Magazine : Item{ // второй подкласс Magazine
    public Magazine(string author, string title) : base(author, title){} //конструктор

    public void FlipThrough(){ //метод1
        Console.WriteLine("Listayu");
    }
    public override void DisplayInfo() //метод для просмотра названия и автора
    {
        Console.WriteLine($"{Title}, {Author}");
    }
}

class DVD : Item{ //3 подкласс DVD
    public DVD(string author, string title) : base(author, title){} // конструктор

    public void Play(){ // первый метод
        Console.WriteLine("Listening");
    }
    public override void DisplayInfo()//метод для просмотра названия и автора
    {
        Console.WriteLine($"{Title}, {Author}");
    }
}



class Program
{
    static void Main(string[] args)
    {
        Book book1 = new Book("Портрет Дориана Грея", "Оскар Уайльд"); //Создаём три новых объекта
        Magazine magazine1 = new Magazine("американец", "Forbes");
        DVD disk1 = new DVD("Не знаю", "NFS");
        List<Item> items = new List<Item>{}; //создаём список для объектов
        items.Add(book1); //добавляем объекты в список(не отвык от питона, поэтому назову списком)
        items.Add(magazine1);
        items.Add(disk1);
        foreach(Item m in items){ //с помощью цикла проходимся по списку и применяем к каждому объекту метод DisplayInfo
            m.DisplayInfo();
        }

        /*book1.Status_Change(); //проверяем 2 новых метода на изменения статуса
        book1.Status_display();
        book1.Sost_Change(); //проверяем 2 новых метода на изменения состояния
        book1.Sost_display();
        book1.Borrow();
        book1.Status_display(); //проверяем меняет метод Borrow знанчения поля Sost */
        Library lib = new Library(items);
        lib.DisplayAllItems();

        
    }
}
