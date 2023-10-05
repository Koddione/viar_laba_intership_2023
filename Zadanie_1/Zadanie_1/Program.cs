using System;
class HelloWorld
{
    static void Main()
    {
        int one = Convert.ToInt32(Console.ReadLine());
        int two = Convert.ToInt32(Console.ReadLine());
        int three = Convert.ToInt32(Console.ReadLine());
        int Max(int one,int two)=>one>two?one:two;
        int Min(int one, int two) => one > two ? two : one;
        int Max3(int one,int two,int three)=>three>Max(one,two)?three:Max(one,two);
        int Min3(int one, int two,int three) => three<Min(one,two)?three:Min(one,two);
        Console.WriteLine(Min3(one, two, three)+ " " +((one + two + three) - (Max3(one,two,three)+Min3(one,two,three))) + " " + Max3(one,two,three));

    }
}
