using System;


namespace mmm;

class Programm{
    static void Main(string[] args){
        int lenghtSp = Convert.ToInt32(Console.Readline());
        string[] shoppingList = new string[lenghtSp];
        int k = 1;
        while (k <= shoppingList.Length){

            Console.Write($"Товар {k}: ");
            shoppingList[0] = Console.ReadLine();
            k++;
        }
        int k=1;

        Console.WriteLine("\nВаш шопинг лист:");
        while(k <= shoppingList){
            Console.WriteLine($"{k}. " + shoppingList[k-1]);
        }
    }

}