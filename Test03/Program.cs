using System;
public class Program
{
    public static void Main(string[] args)
    {
        Queue<string> Filename = new Queue<string>();
        while(true)
        {
            string filename = Console.ReadLine();
        
            if(Filename.GetLength() == 0)
            {
                Filename.Push(filename);

            }
            else if(filename == "Exit" || filename == "exit" )
            {
                break;
            }
            else
            {
                Filename.Push(filename);
            }
        }
        for(int NumFile = 0; NumFile < Filename.GetLength(); NumFile++)
        {
            Console.WriteLine("{0}", Filename.Get(NumFile));
        }
    }
    
}