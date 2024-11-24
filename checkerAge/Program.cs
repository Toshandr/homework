using System;


namespace checkerAge;

    class Program{
        static void Main(string[] args){
            while (true){
                Console.Write("Введите ваш возраст: ");
                int age = Convert.ToInt32(Console.ReadLine());
                if (age > 110 || age < 0){
                    Console.WriteLine("Введите корректные данные.");
                    Console.WriteLine("");
                    continue;
                }
                else if (age >= 18){
                    Console.WriteLine("Вход разрешён.");
                    break;
                }
                else{
                    Console.WriteLine("Доступ не разрешён. Вы не прошли проверку возраста, зайти на сайт можно только" + 
                    $"через {18 - age}.");
                    break;
                }
            }
        }
    }
