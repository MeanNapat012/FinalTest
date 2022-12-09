using System;

class Program
{
    static void Main(string[] args)
    {
        BinaryTree<int> Numtree = new BinaryTree<int>();

        while(true)
        {
            int numtree = int.Parse(Console.ReadLine());
            if(numtree > 0)
            {
                Numtree.Add(numtree);
            }
            else
            {
                for(int i = 0; i < 2;i++)
                {
                    numtree = int.Parse(Console.ReadLine());
                    if(numtree > 0)
                    {
                        Numtree.Add(numtree);
                    }
                }
                break;
            }
        }
        Console.WriteLine("{0}", (Numtree.GetLength()/2)-1);
    }
}