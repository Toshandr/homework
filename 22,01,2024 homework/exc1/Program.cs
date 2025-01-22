namespace exc1;

class Program
{
    abstract class Vehicle{
        public string Name;
        public string Speed;
        public Vehicle(string name, string speed){
            Name = name;
            Speed = speed;
        }
        public abstract void Move();
        public void DisplayInfo(){
            Console.WriteLine($"Транспорт:{Name}, скорость:{Speed}");
        }

    }

    class Car:Vehicle{
        public Car(string name, string speed) : base(name, speed){}

        public override void Move()
        {
            Console.WriteLine("Едет на 4-ёх колёсах");
        }
    }

    class Bicycle:Vehicle{
        public Bicycle(string name, string speed) : base(name, speed){}

        public override void Move()
        {
            Console.WriteLine("Едет на 2-ух колёсах");
        }
    }

    class Boat:Vehicle{
        public Boat(string name, string speed) : base(name, speed){}

        public override void Move()
        {
            Console.WriteLine("плывёт без колёс");
        }
    }


    static void Main(string[] args)
    {
        Car car1 = new Car("Toyota","150");
        Boat boat1 = new Boat("Motor", "120");
        Bicycle bike1 = new Bicycle("Stels", "60");
        car1.Move();
        boat1.DisplayInfo();
        bike1.Move();
    }

}
