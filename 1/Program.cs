using System;


namespace mmm;

class Programm{
    static void Main(string[] args){
        int[] spisokNum = {1,2,3,4,5};
        string[] spisokStr = {"aaaaaa","baaa","caaa"};

        Console.WriteLine(spisokNum[1]);
        spisokNum[2] = 100;
        Console.WriteLine(spisokNum.Length);

        string[] C = new string[4];
        int[] C2 = new int[5];
        char[] C3 = {'a','b','c'};
        C2[0] = 34;
        C2[1] = 35;
        C2[2] = 36;
        C2[3] = 38;
        C3[4] = 'm';

    }

}