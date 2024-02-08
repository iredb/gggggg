using System;

namespace Calucator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isProgramWorking = true;
            
            while (isProgramWorking)
            {
                int taskCoice;

                try
                {
                    Console.WriteLine("choose 1st or 2nd task (print '1' or '2') or 0 to exit");
                    taskCoice = Convert.ToInt32(Console.ReadLine());

                    if (taskCoice == 0)
                    {
                        isProgramWorking = false;
                    }
                    else if (taskCoice == 1)
                    {
                        int a, n;

                        Console.Write("a = ");
                        a = Convert.ToInt32(Console.ReadLine());

                        Console.Write("n = ");
                        n = Convert.ToInt32(Console.ReadLine());

                        int result = 1;

                        for (int currentDegree = 1; currentDegree <= n; ++currentDegree)
                        {
                            result *= a;
                        }

                        Console.WriteLine($"{a} in {n} degree is {result}");
                        Console.WriteLine("finished 1 task.");
                    }
                    else if (taskCoice == 2)
                    {
                        string x, n;

                        Console.Write("x = ");
                        x = Console.ReadLine();

                        n = x + x[1];
                        n = n.Remove(1, 1);

                        Console.WriteLine(n);
                        Console.WriteLine("finished 2 task.");
                    }
                    else
                    {
                        Console.WriteLine("what?");
                    }
                }
                catch
                {
                    Console.WriteLine("there's a mistake somewhere...");
                }

            }

        }

    }

}