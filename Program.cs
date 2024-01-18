// Author: Adam Forbush
// Description: Program file for dice rolling assignment
using mission2;

internal class Program
{
    public static void Main(string[] args)
    {
        // Here I am instantiating the object
        Dice d = new Dice();

        System.Console.WriteLine("Welcome to the dice throwing simulator!" + "\n");
        System.Console.WriteLine("How many dice rolls would you like to simulate?" + "\n");

        // Ask user how many times they want to roll the dice
        int totalRolls = int.Parse(Console.ReadLine() ?? "0");

        System.Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
        System.Console.WriteLine("Each " + "*" + " represents 1% of the total number of rolls.\n");

        // I am calling the RollDice method from the Dice class and passing totalRolls as a parameter
        // the totalRolls is being caught by the rollCounts array.
        int[] rollCounts = d.RollDice(totalRolls);

        // FOR loop to process the percentage and asterisks
        for (int i = 2; i < 12; i++)
        {
            int count = rollCounts[i - 2];
            // percentage = how many times the specific number was rolled / total number of rolls * 100
            int percentage = count * 100 / totalRolls;
            string asterisks = new string('*', percentage);
            System.Console.WriteLine($"{i}: {asterisks}");
        }

        System.Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");
    }
}