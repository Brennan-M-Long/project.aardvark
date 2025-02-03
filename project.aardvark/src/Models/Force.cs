using System;

public static class Force
{
    public static void Calculate()
    {
        Console.Write("Enter mass (kg): ");
        double mass = double.Parse(Console.ReadLine());

        Console.Write("Enter acceleration (m/s²): ");
        double acceleration = double.Parse(Console.ReadLine());

        double force = mass * acceleration;
        Console.WriteLine($"Force = {force} N");
        Console.ReadLine();
    }
}
