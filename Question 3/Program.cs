/*
Question 3
Write a C# program that takes a string as input and checks whether it is a palindrome or not. A
palindrome is a word, phrase, number, or other sequence of characters that reads the same forward
and backward, ignoring spaces, punctuation, and capitalization..
*/

using System;

class Program{
    static void Main(){
        String strInput = Console.ReadLine()?? "";

        bool blnPalindrome = IsPalindrome(strInput);

        Console.WriteLine("Is '{0}' a palindrome? : {1}", strInput, blnPalindrome);
    }

    private static Boolean IsPalindrome(String str){
        int nLength = str.Length;
        for (int i = 0; i < nLength/2; i++)
        if (!Char.Equals(str[i], str[nLength-1-i]))
        return false;
        return true;
    }
}