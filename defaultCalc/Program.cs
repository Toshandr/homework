using System;
using System.Text;


namespace defaultCalc;
//Блин я хотел сделать ввод в одну в строку и потом вместо того чтобы просто вывести результат с этими переменными
//Воспользоваться конструкцией switch
//Но для этого нужно изучит списки(векторы) я не знаю как они в шарпе называются
//Я это изучу потом, поэтому ввод я сделал в 3 строки и воспользовался switch-ем, простите , пожалуйста
//Ну уж очень хочется воспользоваться этой конструкцией :(
// Переменная 'AAA' это уже мой крик души пока дебажил косяки
class Programm{
    static void Main(string[] args){
        Console.InputEncoding = Encoding.Unicode;
        Console.OutputEncoding = Encoding.Unicode;
        string secChoice;
        string Choice;
        int firstNumber;
        int secondNumber;
        string mathSymbol;
        bool AAA = true;
        Console.WriteLine("");
        Console.WriteLine("Вас приветствует простой калькулятор! Я могу выполнять различные математические вычисления.");
        Console.WriteLine("Я написан на высокоуровнем языке C#, да я из семейства C, приятно познакомиться. если что я работаю при помощи конструкции switch");
        Console.WriteLine("Я только только начал учиться считать, поэтому могу выполнять действия только с двумя целыми переменными...");
        Console.WriteLine("");
        Console.WriteLine("Решим уравнение?");
        Choice = Console.ReadLine();
        if (Choice == "Да" || Choice == "да" || Choice == "ДА"){
            while(AAA == true){
                Console.WriteLine("Введите первое число: ");
                firstNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите математическое действие: ");
                mathSymbol = Console.ReadLine();
                Console.WriteLine("Введите второе число: ");
                secondNumber = Convert.ToInt32(Console.ReadLine());
                int Answer = 0;
                switch (mathSymbol){
                    case "+":
                        Answer = firstNumber + secondNumber;
                        Console.WriteLine($"Результат: {Answer}");
                        Console.Write("Будем ещё считать? ");
                        secChoice = Console.ReadLine();
                        if (secChoice == "Да" || secChoice == "да" || secChoice == "ДА"){
                            continue;
                        }
                        if (secChoice == "нет" || secChoice == "Нет" || secChoice == "НЕТ"){
                            Console.WriteLine("Ну, ладно");
                            AAA = false;
                        }
                        else{
                            Console.WriteLine("");
                            AAA = false;
                        }
                        break;
                    case "-":
                        Answer = firstNumber - secondNumber;
                        Console.WriteLine($"Результат: {Answer}");
                        Console.Write("Будем ещё считать? ");
                        secChoice = Console.ReadLine();
                        if (secChoice == "Да" || secChoice == "да" || secChoice == "ДА"){
                            continue;
                        }
                        if (secChoice == "нет" || secChoice == "Нет" || secChoice == "НЕТ"){
                            Console.WriteLine("Ну, ладно");
                            AAA = false;
                        }
                        else{
                            Console.WriteLine("");
                            AAA = false;
                        }
                        break;
                    case "*":
                        Answer = firstNumber * secondNumber;
                        Console.WriteLine($"Результат: {Answer}");
                        Console.Write("Будем ещё считать? ");
                        secChoice = Console.ReadLine();
                        if (secChoice == "Да" || secChoice == "да" || secChoice == "ДА"){
                            continue;
                        }
                        if (secChoice == "нет" || secChoice == "Нет" || secChoice == "НЕТ"){
                            Console.WriteLine("Ну, ладно");
                            AAA = false;
                        }
                        else{
                            Console.WriteLine("");
                            AAA = false;
                        }
                        break;
                    case "/":
                        Answer = firstNumber / secondNumber;
                        Console.WriteLine($"Результат: {Answer}");
                        Console.Write("Будем ещё считать? ");
                        secChoice = Console.ReadLine();
                        if (secChoice == "Да" || secChoice == "да" || secChoice == "ДА"){
                            continue;
                        }
                        if (secChoice == "нет" || secChoice == "Нет" || secChoice == "НЕТ"){
                            Console.WriteLine("Ну, ладно");
                            AAA = false;
                        }
                        else{
                            Console.WriteLine("");
                            AAA = false;
                        }
                        break;
                    case "%":
                        Answer = firstNumber % secondNumber;
                        Console.WriteLine($"Результат: {Answer}");
                        Console.Write("Будем ещё считать? ");
                        secChoice = Console.ReadLine();
                        if (secChoice == "Да" || secChoice == "да" || secChoice == "ДА"){
                            continue;
                        }
                        if (secChoice == "нет" || secChoice == "Нет" || secChoice == "НЕТ"){
                            Console.WriteLine("Ну, ладно");
                            AAA = false;
                        }
                        else{
                            Console.WriteLine("");
                            AAA = false;
                        }
                        break;
            }
        }
    }
    if (Choice == "Нет" || Choice == "нет" || Choice == "НЕТ"){
        Console.WriteLine("Ну, как хочешь");
    }
    else{
        Console.WriteLine("");
    }
}
        
}

