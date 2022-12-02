using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class lab4
{
    public int dot_in_area()
    {
        return 0;
    }

    public static void lab2task2Method(double steph, double yy, int x2, int xx1)
    {
        for (double x = xx1; x <= x2; x += steph)
        {
            Console.WriteLine("x = " + x);
            if (x < 0)
            {
                yy = 2 * Math.Cos(x - 1);
                Console.WriteLine("y = " + yy);
            }
            else if (0 <= x && x <= 3 * 3.14)
            {
                yy = 1;
                Console.WriteLine("y = " + yy);
            }
            else if (x > 3 * 3.14)
            {
                yy = Math.Sin(x + 1);
                Console.WriteLine("y = " + yy);
            }
            Console.WriteLine("-----------------------");
        }
    }

    public static void var2()
    {
        Console.WriteLine("Choose task: ");
        int task = Convert.ToInt32(Console.ReadLine());
        switch (task)
        {
            case 1:
                double steph;
                double yy;
                int x2;
                Console.Clear();
                Console.WriteLine("Lab 4");
                Console.WriteLine("Task 2 from lab 2 with FOR cycle");
                Console.Write("Enter step: ");
                steph = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter start value: ");
                int xx1 = Convert.ToInt16(Console.ReadLine());
                Console.Write("Enter end value: ");
                x2 = Convert.ToInt16(Console.ReadLine());

                for (double x = xx1; x <= x2; x += steph)
                {
                    Console.WriteLine("x = " + x);
                    if (x < 0)
                    {
                        yy = 2 * Math.Cos(x - 1);
                        Console.WriteLine("y = " + yy);
                    }
                    else if (0 <= x && x <= 3 * 3.14)
                    {
                        yy = 1;
                        Console.WriteLine("y = " + yy);
                    }
                    else if (x > 3 * 3.14)
                    {
                        yy = Math.Sin(x + 1);
                        Console.WriteLine("y = " + yy);
                    }
                    Console.WriteLine("-----------------------");
                }
                break;
            case 2:

                break;
            case 3:
                break;
        }
    }
}