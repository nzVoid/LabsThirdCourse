using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 internal class lab3
 {
    public static void var2()
    {
        Console.WriteLine("Choose task: ");
        int task = Convert.ToInt32(Console.ReadLine());
        switch (task)
        {
            case 1:
                double x1;
                int x2;
                double yy;
                double steph;
                Console.WriteLine("Choose cycle: ");
                Console.WriteLine("1) for ");
                Console.WriteLine("2) while ");
                Console.WriteLine("3) do-while ");
                int cycle = Convert.ToInt32(Console.ReadLine());
                switch (cycle)
                {
                    case 1:
                        Console.WriteLine("Task 2 from lab 2 with for cycle");
                        Console.Write("Enter step: ");
                        steph = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter start value: ");
                        int xx1 = Convert.ToInt16(Console.ReadLine());
                        Console.Write("Enter end value: ");
                        x2 = Convert.ToInt16(Console.ReadLine());
                        
                        for (double x = xx1; x<=x2; x+=steph)
                        {
                            Console.WriteLine("x = "+x);
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
                        Console.WriteLine("Task 2 from lab 2 with while cycle");
                        Console.Write("Enter step: ");
                        steph = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter start value: ");
                        x1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter end value: ");
                        x2 = Convert.ToInt16(Console.ReadLine());
                        while (x1 <= x2)
                        {
                            Console.WriteLine("x = " + x1);
                            if (x1 < 0)
                            {
                                yy = 2 * Math.Cos(x1 - 1);
                                Console.WriteLine("y = " + yy);
                            }
                            else if (0 <= x1 && x1 <= 3 * 3.14)
                            {
                                yy = 1;
                                Console.WriteLine("y = " + yy);
                            }
                            else if (x1 > 3 * 3.14)
                            {
                                yy = Math.Sin(x1 + 1);
                                Console.WriteLine("y = " + yy);
                            }
                            Console.WriteLine("-----------------------");
                            x1 += steph;
                        }
                        
                        break;
                    case 3:
                        Console.WriteLine("Task 2 from lab 2 with do-while cycle");
                        Console.Write("Enter step: ");
                        steph = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter start value: ");
                        x1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter end value: ");
                        x2 = Convert.ToInt16(Console.ReadLine());
                        do
                        {
                            Console.WriteLine("x = " + x1);
                            if (x1 < 0)
                            {
                                yy = 2 * Math.Cos(x1 - 1);
                                Console.WriteLine("y = " + yy);
                            }
                            else if (0 <= x1 && x1 <= 3 * 3.14)
                            {
                                yy = 1;
                                Console.WriteLine("y = " + yy);
                            }
                            else if (x1 > 3 * 3.14)
                            {
                                yy = Math.Sin(x1 + 1);
                                Console.WriteLine("y = " + yy);
                            }
                            Console.WriteLine("-----------------------");
                            x1 += steph;
                        }
                        while (x1 <= x2) ;                    
                        break;
                }
                break;
        }
    }
 }
