using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class lab2
{
    public static bool triangle(float x, float y,
            float x1, float y1,
            float x2, float y2,
            float x3, float y3)
    {
        float a = (x - x1) * (y - y2) - (x - x2) * (y - y1),
            b = (x - x2) * (y - y3) - (x - x3) * (y - y2),
            c = (x - x3) * (y - y1) - (x - x1) * (y - y3);
        return ((a >= 0 && b >= 0 && c >= 0) ||
            (a <= 0 && b <= 0 && c <= 0));
    }

    public static void var2()
    {   
        Console.WriteLine("Choose task: ");
        int task = Convert.ToInt32(Console.ReadLine());
        switch (task) {
            case 1:
                Console.WriteLine("Task 1");
                int x, y, x1 = -1, y1 = -1, x2 = 1, y2 = -1, x3 = 0, y3 = 0;
                x = Convert.ToInt16(Console.ReadLine());
                y = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine(triangle(x, y, x1, y1, x2, y2, x3, y3));
                break;
            case 2:
                Console.WriteLine("Task 2");
                Console.WriteLine("x = -2");
                double xx = -2;
                double yy;
                if(xx < 0)
                {
                    yy = 2 * Math.Cos(xx - 1);
                    Console.WriteLine("y = " + yy);
                }
                else if(0<=xx && xx <= 3 * 3.14)
                {
                    yy = 1;
                    Console.WriteLine("y = " + yy);
                }
                else if (xx > 3 * 3.14)
                {
                    yy = Math.Sin(xx + 1);
                    Console.WriteLine("y = " + yy);
                }

                Console.WriteLine("x = 1");
                xx = 1;
                if (xx < 0)
                {
                    yy = 2 * Math.Cos(xx - 1);
                    Console.WriteLine("y = " + yy);
                }
                else if (0 <= xx && xx <= 3 * 3.14)
                {
                    yy = 1;
                    Console.WriteLine("y = " + yy);
                }
                else if (xx > 3 * 3.14)
                {
                    yy = Math.Sin(xx + 1);
                    Console.WriteLine("y = " + yy);
                }

                Console.WriteLine("x = 8");
                xx = 8;
                if (xx < 0)
                {
                    yy = 2 * Math.Cos(xx - 1);
                    Console.WriteLine("y = " + yy);
                }
                else if (0 <= xx && xx <= 3 * 3.14)
                {
                    yy = 1;
                    Console.WriteLine("y = " + yy);
                }
                else if (xx > 3 * 3.14)
                {
                    yy = Math.Sin(xx + 1);
                    Console.WriteLine("y = " + yy);
                }
                break;

            case 3:
                var days = new Dictionary<int, int>()
                {
                    [1]=3,
                    [2]=1,
                    [3]=4,
                    [4]=2,
                    [5]=2,
                };
                Console.WriteLine("Task 3");
                Console.WriteLine("Choose day: ");
                int day = Convert.ToInt16(Console.ReadLine());
                switch (day)
                {
                    case 1:
                        Console.WriteLine("Day " + day + " value of lesson " + days[day]);
                        break;
                    case 2:
                        Console.WriteLine("Day " + day + " value of lesson " + days[day]);
                        break;
                    case 3:
                        Console.WriteLine("Day " + day + " value of lesson " + days[day]);
                        break;
                    case 4:
                        Console.WriteLine("Day " + day + " value of lesson " + days[day]);
                        break;
                    case 5:
                        Console.WriteLine("Day " + day + " value of lesson " + days[day]);
                        break;
                }
                break;
        }
    }

    public static void var3()
    {
        Console.WriteLine("Choose task: ");
        int task = Convert.ToInt32(Console.ReadLine());
        switch (task)
        {
            case 1:
                Console.WriteLine("Task 1");
                
                break;
            case 2:
                Console.WriteLine("Task 2");

                break;
            case 3:
                Console.WriteLine("Task 3");
               
                break;
        }
    }
}

