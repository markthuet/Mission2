using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission2
{
    // Merged DiceRoller class from the existing code and the provided code

    public class DiceRoller
    {
        public int[] SimulateRolls(int numOfRolls)
        {
            // Initialize the array to keep track of combinations
            int[] results = new int[11];

            // Create an instance of Random for simulating dice rolls
            Random random = new Random();

            for (int i = 0; i < numOfRolls; i++)
            {
                // Roll two dice and calculate the sum
                int dice1 = random.Next(1, 7);
                int dice2 = random.Next(1, 7);
                int sum = dice1 + dice2;

                // Increment the corresponding element in the results array
                results[sum - 2]++;
            }

            return results;
        }
    }
}
