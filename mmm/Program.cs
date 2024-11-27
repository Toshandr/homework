using System;


namespace mmm;

class Programm{
    static void Main(string[] args){
        int lenghtSp = Convert.ToInt32(Console.ReadLine());
        string[] shoppingList = new string[lenghtSp];
        int k = 1;
        while (k <= shoppingList.Length){

            Console.Write($"Товар {k}: ");
            shoppingList[k-1] = Console.ReadLine();
            k++;
        }
        k=1;

        Console.WriteLine("\nВаш шопинг лист:");
        while(k <= shoppingList.Length){
            Console.WriteLine($"{k}. " + shoppingList[k-1]);
            k++;
        }
    }

}