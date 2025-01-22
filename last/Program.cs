using System.IO.Pipelines;
using System.Reflection.PortableExecutable;
using System.Security.AccessControl;

// Задача:
// Написать класс "Животное", которое бы обладало характеристиками (название, размер, тип еды), 
// и у которого было бы два действия: увеличить размер и издать звук.
namespace task1
{   
    class Animal
    {
        // Свойства объектов
        public string Name {get; set;}
        public int Size {get; set;}
        public string FoodType {get; set;}

        // Конструктор для инициализации объекта класса
        public Animal(string name, int size, string foodType)
        {
            Name=name;
            Size=size;
            FoodType=foodType;
        }

        // Метод для вывода информации о животном
        public void Describe()
        {
            Console.WriteLine($"Имя: {Name}, Размер: {Size}, Тип пищи: {FoodType}");
        }

        // Метод для увеличения размера животного
        public void ChangeSize(int plussize_value)
        {
            Size += plussize_value;
        }

        // Метод для издания звука животным
        public virtual void MakeSound()
        {
            Console.WriteLine("Животное издает звук");
        }

        public void Introduce(string kind){
            if(kind == "kind"){
                Console.WriteLine($"Привет! Меня зовут {name}! Приятно познакомитьься.");
            }
            if(kind == "evil"){
                Console.WriteLine("Вечере в хату, Дон");
            }
            else{
                Console.WriteLine($"Привет, {Name}!");
            }
            
        }
    }


    class Dog : Animal
    {
        // Конструктор
        public Dog(string name, int size, string foodType)
            : base(name, size, foodType) { }

        public override void MakeSound()
        {
            Console.WriteLine("Гав-гав");
        }  
    }

    class Cat : Animal
    {
        // Конструктор
        public Cat(string name, int size, string foodType)
            : base(name, size, foodType) { }

        public override void MakeSound()
        {
            Console.WriteLine("Мяяяяяяяяяяяяяяяяу");
        }  
    }

 

    class Program
    {
        static void Main(string[] args)
        {
            Animal dino = new Animal("динозавр", 100, "мясо");
            Dog dog1 = new Dog("Бобик", 20, "собачий корм");
            Cat cat1 = new Cat("Сэм", 10, "кошачий корм");

            dino.MakeSound();
            cat1.MakeSound();
            dog1.MakeSound();

        }
    }
}
