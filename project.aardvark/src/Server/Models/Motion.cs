// Motion.cs
using System;

public static class Motion
{
    public static void Calculate()
    {
        Console.Clear();
        Console.WriteLine("=== Motion Equations ===");
        Console.WriteLine("1. Final Velocity (v = u + at)");
        Console.WriteLine("2. Displacement (s = ut + 0.5 * at^2)");
        Console.WriteLine("3. Velocity Squared (v^2 = u^2 + 2as)");
        Console.WriteLine("0. Back to Main Menu");
        Console.Write("Select an option: ");

        switch (Console.ReadLine())
        {
            case "1":
                CalculateFinalVelocity();
                break;
            case "2":
                CalculateDisplacement();
                break;
            case "3":
                CalculateVelocitySquared();
                break;
            case "0":
                return;
            default:
                Console.WriteLine("Invalid option.");
                break;
        }
        Console.ReadLine();
    }

    private static void CalculateFinalVelocity()
    {
        Console.Write("Enter initial velocity (u) in m/s: ");
        double initialVelocity = double.Parse(Console.ReadLine());
        Console.Write("Enter acceleration (a) in m/s²: ");
        double acceleration = double.Parse(Console.ReadLine());
        Console.Write("Enter time (t) in seconds: ");
        double time = double.Parse(Console.ReadLine());

        double finalVelocity = initialVelocity + (acceleration * time);
        Console.WriteLine($"Final Velocity (v) = {finalVelocity} m/s");
    }

    private static void CalculateDisplacement()
    {
        Console.Write("Enter initial velocity (u) in m/s: ");
        double initialVelocity = double.Parse(Console.ReadLine());
        Console.Write("Enter time (t) in seconds: ");
        double time = double.Parse(Console.ReadLine());
        Console.Write("Enter acceleration (a) in m/s²: ");
        double acceleration = double.Parse(Console.ReadLine());

        double displacement = (initialVelocity * time) + (0.5 * acceleration * Math.Pow(time, 2));
        Console.WriteLine($"Displacement (s) = {displacement} meters");
    }

    private static void CalculateVelocitySquared()
    {
        Console.Write("Enter initial velocity (u) in m/s: ");
        double initialVelocity = double.Parse(Console.ReadLine());
        Console.Write("Enter acceleration (a) in m/s²: ");
        double acceleration = double.Parse(Console.ReadLine());
        Console.Write("Enter displacement (s) in meters: ");
        double displacement = double.Parse(Console.ReadLine());

        double finalVelocitySquared = Math.Pow(initialVelocity, 2) + (2 * acceleration * displacement);
        Console.WriteLine($"Final Velocity Squared (v²) = {finalVelocitySquared} m²/s²");
    }
}
