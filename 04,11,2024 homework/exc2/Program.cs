namespace exc2;

class Program
{
    static void Main(string[] args)
    {
        int[] mainMass = {1,2,3,4,5};    //основной массив с которым мы будем работать
        int[] ansMass = new int[mainMass.Length];    //массив который пойдёт в ответ
        Console.Write("Изначальный вид массива: ");
        foreach(int i in mainMass){
            Console.Write(i + " ");
        }
        Console.WriteLine(" ");
        Console.Write("Введите число на которое нужно сместить массив: ");
        int request = Convert.ToInt32(Console.ReadLine());
        for(int i = 0; i < mainMass.Length; i++){    //проходимся по индексу основного массива
            if (i + request < mainMass.Length){    //проверка на то выйдем ли мы за пределы массива: в данном случае если мы не выйдем за пределы
                ansMass[i + request] = mainMass[i];    //просто перекидываем в ansMass значение из основнгого массива, но с изменённым индексом ровно на request
            }
            if (i + request >= mainMass.Length){    // проверка вдруг мы всё-таки вышли за пределы массива
                ansMass[(i + request)%mainMass.Length] = mainMass[i];    //тогда мы складываем индекс и запрос пользователья, смотрим на остаток от деления на длинну основного массива и закидываем значение в ansMass с новым индексом
            }
        }
        Console.Write("Конечный вид массива: ");
        foreach(int i in ansMass){    //просто проходимся по массиву
            Console.Write(i + " ");    //для красоты сделаем вывод черз пробел
        }
    }
}
