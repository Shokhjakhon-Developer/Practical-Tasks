
class Program
{

    static char convert(int num)
    {
        if (num >= 0 && num <= 9)
            return (char)(num + 48);
        else
            return (char)(num - 10 + 65);
    }

   
    static string converToNewBase(int baseNum, int inputNum)
    {
        string s = "";

        while (inputNum > 0)
        {
            s += convert((inputNum % baseNum));
            inputNum /= baseNum;
        }
        char[] result = s.ToCharArray();

        Array.Reverse(result);
        return new string(result);
    }

    static void Main()
    {
        //I had problems on my machine with Read, ReadLine methods so I just wrote a program without having user input feature.
        int inputNum = 16;
        int baseNum = 20;
        Console.WriteLine(inputNum +" in base " + baseNum + " is " + converToNewBase(baseNum, inputNum));
    }
}
