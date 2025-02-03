using System;

public static class Menu
{
    public static void ShowMainMenu()
    {
        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("=== Physics Calculator ===");
            Console.WriteLine("1. Calculate Force");
            Console.WriteLine("2. Calculate Energy");
            Console.WriteLine("3. Motion Equations");
            Console.WriteLine("0. Exit");
            Console.Write("Choose an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    Force.Calculate();
                    break;
                case "2":
                    Energy.Calculate();
                    break;
                case "3":
                    Motion.Calculate();
                    break;
                case "0":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }
}
