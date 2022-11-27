using System.ComponentModel;
using System.Diagnostics;
using static lab2;

class LabsThirdCourse
{
    public static void function()
    {
        Console.WriteLine("1 = exit, 2 = restart");
        int mod = Convert.ToInt16(Console.ReadLine());
        switch (mod)
        {
            case 1:
                Console.WriteLine("Bye!");
                break;
            case 2:
                Console.Clear();
                Main();
                break;
        }
    }

    static int Main()
    {
        Console.WriteLine("All labs of C#");
        Console.WriteLine("Choose lab: (start with 2)");
        int choose_lab = Convert.ToInt16(Console.ReadLine());
        switch (choose_lab)
        {           
            case 2:
                Console.WriteLine("Lab 2");
                Console.Write("Choose var: ");
                int v = Convert.ToInt16(Console.ReadLine());
                switch (v)
                {
                    case 1:
                        Console.WriteLine("not found");
                        function();
                        break;
                    case 2:
                        lab2.var2();
                        function();
                        break;

                }
                break;
            case 3:
                Console.WriteLine("Lab 3");
                Console.Write("Choose var: ");
                int va = Convert.ToInt16(Console.ReadLine());
                switch (va)
                {
                    case 1:
                        Console.WriteLine("not found");
                        function();
                        break;
                    case 2:
                        lab3.var2();
                        function();
                        break;
                }
                break;
            default:
                Console.WriteLine("Choose corectly number!");
                Main();
                break;
        }
        
        return 0;
    }
}