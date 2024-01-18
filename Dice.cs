using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mission2
{
    // Declaration of the Dice class
    internal class Dice
    {
        // This object is used to generate random numbers, simulating dice rolls.
        Random random = new Random();
        
        // This is the declaration of the RollDice method which is public so it can be viewed outside the class.
        public int[] RollDice(int totalRolls)
        {
            int die1 = 0;
            int die2 = 0;
            int total = 0;

            int[] totalCount = new int[11];

            // FOR loop to generate and calculate the dice roll that we are simulating.
            for (int iCount = 0; iCount < totalRolls; iCount++)
            {
                // Roll the two dice
                die1 = random.Next(1, 7);
                die2 = random.Next(1, 7);
                total = die1 + die2;

                totalCount[total - 2]++;
            }

            // After the loop completes, the method returns the 'totalCount' array, which contains the count
            // of each possible sum from the dice rolls.
            return totalCount;
        }
    }
}
