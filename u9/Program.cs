namespace u9;

class Program
{
    int[] spisok = {1,-2,3,-4,5,-6,-7};
    foreach (int i in spisok){
        if (i<0){
            spisok[i] = 0;
        }
    }
    foreach (int i in spisok)
    {
        Console.WriteLine(i);
    }


}
