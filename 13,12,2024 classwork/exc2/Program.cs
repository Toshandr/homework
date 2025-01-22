namespace exc2;

class Program
{
    static void Main(string[] args)
    {
        string a = Console.ReadLine();
        string a1 = a[0].ToString();
        string a2 = a[1].ToString();
        string a3 = a[2].ToString();
        string a4 = a[3].ToString();
        burgle(a1, a2, a3, a4);
    }

    static void burgle(string a, string b, string c, string d){
        int k = 0;
        for(int i = 0; i < 10; i++){
            for(int j = 0; j < 10; j++){
                for(int m = 0; m < 10; m++){
                    for(int n = 0; n < 10; n++){
                        if(i.ToString() != a && j.ToString() != b && m.ToString() != c && n.ToString() != d){
                            k += 1;
                        }
                        if(i.ToString() == a && j.ToString() == b && m.ToString() == c && n.ToString() == d){
                            Console.WriteLine(k);
                            Console.WriteLine(a + b + c + d);
                        }
                    }
                }
            }

        }
    }

}
