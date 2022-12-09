using System;

public class Program
{
    static void Main(string[] args)
    {
        Queue<string> Repairlist = new Queue<string>();
        int i = 0;
        while(true)
        {
              string repair = Console.ReadLine();
              if(repair == "true" || repair == "false")
              {
                i++;
                if(i >= 8)
                {
                    break;
                }
              }
              else
              {
                Repairlist.Push(repair);
              }
        }
        Console.Clear();
        Console.WriteLine("{0} ({1})", Repairlist.Get(0), Repairlist.Get(1));
        Console.WriteLine("{0} ({1})", Repairlist.Get(2), Repairlist.Get(3));
        Console.WriteLine("{0} ({1})", Repairlist.Get(4), Repairlist.Get(5));
        Console.WriteLine("{0} ({1})", Repairlist.Get(6), Repairlist.Get(7));
        Console.WriteLine("{0} ({1})", Repairlist.Get(8), Repairlist.Get(9));
        Console.WriteLine("{0} ({1})", Repairlist.Get(10), Repairlist.Get(11));        
        Console.WriteLine("{0} ({1})", Repairlist.Get(12), Repairlist.Get(13));        
        Console.WriteLine("{0} ({1})", Repairlist.Get(14), Repairlist.Get(15));        
    }
}