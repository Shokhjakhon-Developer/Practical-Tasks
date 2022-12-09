using System;
using System.Collections;
using System.ComponentModel;

class Program
{

    static char Convert(int num)
    {
        if (num >= 0 && num <= 9)
            return (char)(num + 48);
        else
            return (char)(num - 10 + 65);
    }

   
    static string ConverToNewBase(int baseNum, int inputNum)
    {
        string tempResult = string.Empty;

        while (inputNum > 0)
        {
            tempResult += Convert((inputNum % baseNum));
            inputNum /= baseNum;
        }
        char[] result = tempResult.ToCharArray();

        Array.Reverse(result);
        return new string(result);
    }

    static void Main()
    {
        Int32Converter converter = new Int32Converter();
        Console.WriteLine("Enter your number: ");
        var inputNum = converter.ConvertFromString(Console.ReadLine());
        Console.WriteLine("Enter your new base: ");
        var baseNum = converter.ConvertFromString(Console.ReadLine());
        
        Console.WriteLine(inputNum +" in base " + baseNum + " is " + ConverToNewBase((int)baseNum, (int)inputNum)  + ".");
    }
}
