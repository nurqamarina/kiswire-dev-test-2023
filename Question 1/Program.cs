// See https://aka.ms/new-console-template for more information

/* 
Question 1
Write a C# function that takes an integer parameter n and returns the sum of all numbers from 1 to
n. For example, if n is 5, the function should return 15 (1 + 2 + 3 + 4 + 5).
*/

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