using System;

public class Program
{
    public static void Main(String[] args)
    {
        Queue<char> Bracket = new Queue<char>();
        Char bracket;
        int i = 0;
        int j = 0;

        while(true)
        {
            bracket = char.Parse(Console.ReadLine());
            if(bracket == '(')
            {
                Bracket.Push('(');
                i++;
            }
            else if(bracket == ')')
            {
                Bracket.Push('(');
                j++;
            }
            else
            {
                break;
            }
        }
        if(Bracket.GetLength() % 2 == 0)
        {
            if(i == j)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");

            }
        }
        else
        {
            Console.WriteLine("Invalid");
        }
    }
}