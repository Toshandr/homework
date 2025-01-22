namespace exc1;

class Program
{
    abstract class Vehicle(string Name, string Speed){
        public Vehicle(string name, string speed){
            Name = name;
            Speed = speed;
        }
        public abstract void Move();
        public void DisplayInfo(){
            Console.WriteLine($"Транспорт:{name}, скорость:{speed}");
        }

    }

    class Car:Vehicle{
        public Car(string name, string speed) : base(name, speed);

        public override void Move()
        {
            Console.WriteLine("Едет на 4-ёх колёсах");
        }
    }

    class Bicycle:Vehicle{
        public Bicycle(string name, string speed) : base(name, speed);

        public override void Move()
        {
            Console.WriteLine("Едет на 2-ух колёсах");
        }
    }

    class Boat:Vehicle{
        public Boat(string name, string speed) : base(name, speed);

        public override void Move()
        {
            Console.WriteLine("плывёт без колёс");
        }
    }


    static void Main(string[] args)
    {
        Console.WriteLine(Boat.Move());
    }

}
