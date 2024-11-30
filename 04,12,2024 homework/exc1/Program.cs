namespace exc1;

class Program
{
    static void Main(string[] args)
    {
        int[] mass1 = {1,2,3,4,5,6};
        int[] mass2 = {7,8,9,10};
        int[] mainMass = new int[mass1.Length + mass2.Length];
        for (int i = 0; i < mass1.Length; i++){
            mainMass[i] = mass1[i];
        }
        for (int i = mass1.Length, j = 0; i < mainMass.Length; i++, j++){
            mainMass[i] = mass2[j];
        }
        foreach (int i in mainMass){
            Console.Write(i + " ");
        }
    }
}
