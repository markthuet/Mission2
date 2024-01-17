// Author: Mark Thuet
// Description: This is a program that roles two 6 sided die and keeps track of the roles. It then prints it out into 
// a histogram type to show which numbers it had the most.
using System;

namespace Mission2
{
    //Create a class to store it in 
    class DiceSimulator
    {
        static void Main()
        {
            Console.WriteLine("Welcome to the dice throwing simulator!");
            Console.WriteLine();

            // Get the number of rolls from the user
            Console.Write("How many dice rolls would you like to simulate? ");
            int numOfRolls = int.Parse(Console.ReadLine());
            Console.WriteLine();

            // Create an instance of the DiceRoller class
            DiceRoller diceRoller = new DiceRoller();

            // Get the results array from the diceRoller
            int[] results = diceRoller.SimulateRolls(numOfRolls);

            // Print the simulation results as a histogram
            PrintHistogram(results, numOfRolls);
            Console.WriteLine();
            Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
        }
        // Print out the information they need and the number of rolls inputed
        static void PrintHistogram(int[] results, int totalRolls)
        {
            Console.WriteLine("DICE ROLLING SIMULATION RESULTS");

            Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");

            Console.WriteLine($"Total number of rolls = {totalRolls}.\n");
            Console.WriteLine();
            // Create  for loop to be able to calculate the percentage and then turn that into a integer
            // so we know where to put an astris.

            for (int i = 2; i <= 12; i++)
            {
                int percentage = results[i - 2] * 100 / totalRolls;

                // Print the combination and its percentage using "*"
                Console.WriteLine($"{i}: {new string('*', percentage)}");
            }
        }
    }
}
