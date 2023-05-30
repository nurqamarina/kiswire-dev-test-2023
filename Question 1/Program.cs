// See https://aka.ms/new-console-template for more information
using System;

class Program{
private static int SumToN(int n)
{
    int result = 0;

    for (int i =1; i <= n;++i)
    {
        result += i;
    }
    return result;
}
public static void Main(){
    Console.WriteLine("Sum of integers up to N={0} is: {1}",5,SumToN(5));
}
}