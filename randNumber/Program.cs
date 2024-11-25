using System;


namespace randNumber;

class Programm{
    static void Main(string[] args){
        int randomNumber = 43;
        Console.WriteLine("");
        Console.WriteLine("Здравствуй, я сотрудник магазина DNS");
        Console.WriteLine("У меня есть купон на скидку на несколько пар наушников. Но нужно угадать какая в нём скидка!");
        Console.WriteLine("Хотите попробовать?");
        Console.WriteLine("1. Да");
        Console.WriteLine("2. Нет");
        Console.WriteLine("");
        int answerBegin = Convert.ToInt32(Console.ReadLine());
        if (answerBegin == 1)
        {
            Console.WriteLine("Ну-ка попробуй, если что помогу");
            while (true){
                int answerMain = Convert.ToInt32(Console.ReadLine());
                if (answerMain > randomNumber){
                    Console.WriteLine("Мимо. Скидка меньше! Не забывай скидка может быть максимум 100%");
                    Console.WriteLine("Давай по новой");
                    Console.WriteLine("Угадывай число");
                    continue;
                }
                if (answerMain < randomNumber){
                    Console.WriteLine("Мимо. Скидка больше! Не забывай скидка может быть минимум 1%");
                    Console.WriteLine("Давай по новой");
                    Console.WriteLine("Угадывай число");
                    continue;
                }
                if (answerMain == randomNumber){
                    Console.WriteLine("Поздравляю, ты угадал");
                    break;
            }
            }
            Console.WriteLine("Можешь взять купон и выбрать свои наушники!");
            Console.ReadLine();
        }
         if (answerBegin == 2 || answerBegin != 1){
            Console.WriteLine("Не задерживай очередь, чувак");
            Console.ReadLine("");
        }
    }
}