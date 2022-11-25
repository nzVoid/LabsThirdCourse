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

    public static void choose_var(int var)
    {
        switch (var)
        {
            case 1:
                Console.WriteLine("not found");
                function();
                break;
            case 2:
                lab2.var2();
                function();
                break;
            case 3:
                lab2.var3();
                function();
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
                int variant = Convert.ToInt16(Console.ReadLine());
                choose_var(variant);
                break;
            default:
                Console.WriteLine("Choose corectly number!");
                Main();
                break;
        }
        
        return 0;
    }
}