// Energy.cs
using System;

public static class Energy
{
    public static void Calculate()
    {
        Console.Clear();
        Console.WriteLine("=== Energy Calculations ===");
        Console.WriteLine("1. Einstein's Equation (E = mc^2)");
        Console.WriteLine("2. Kinetic Energy (KE = 0.5 * m * v^2)");
        Console.WriteLine("3. Potential Energy (PE = m * g * h)");
        Console.WriteLine("0. Back to Main Menu");
        Console.Write("Select an option: ");

        switch (Console.ReadLine())
        {
            case "1":
                CalculateMassEnergy();
                break;
            case "2":
                CalculateKineticEnergy();
                break;
            case "3":
                CalculatePotentialEnergy();
                break;
            case "0":
                return;
            default:
                Console.WriteLine("Invalid option.");
                break;
        }
        Console.ReadLine();
    }

    private static void CalculateMassEnergy()
    {
        Console.Write("Enter mass (kg): ");
        double mass = double.Parse(Console.ReadLine());
        double c = 3e8; // Speed of light (m/s)
        double energy = mass * Math.Pow(c, 2);
        Console.WriteLine($"Energy (E) = {energy} Joules");
    }

    private static void CalculateKineticEnergy()
    {
        Console.Write("Enter mass (kg): ");
        double mass = double.Parse(Console.ReadLine());
        Console.Write("Enter velocity (m/s): ");
        double velocity = double.Parse(Console.ReadLine());
        double ke = 0.5 * mass * Math.Pow(velocity, 2);
        Console.WriteLine($"Kinetic Energy (KE) = {ke} Joules");
    }

    private static void CalculatePotentialEnergy()
    {
        Console.Write("Enter mass (kg): ");
        double mass = double.Parse(Console.ReadLine());
        Console.Write("Enter height (m): ");
        double height = double.Parse(Console.ReadLine());
        double g = 9.81; // Acceleration due to gravity (m/s^2)
        double pe = mass * g * height;
        Console.WriteLine($"Potential Energy (PE) = {pe} Joules");
    }
}