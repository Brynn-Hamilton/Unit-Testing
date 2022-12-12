using System;
using System.Collections.Generic;
Console.WriteLine("Hello");

namespace UnitTesting
{

    public class Methods
    {
        public static string RockPaperScissors(string player1, string player2)
        {
            if (player1 == player2)
            {
                return "It's a tie!";
            }
            else if ((player1 == "rock" && player2 == "scissors") ||
                        (player1 == "scissors" && player2 == "paper") ||
                        (player1 == "paper" && player2 == "rock"))
            {
                return "Player 1 wins!";
            }
            else
            {
                return "Player 2 wins!";
            }
        }

        public static List<int> SortNums(List<int> numbers)
        {
            List<int> sorted = numbers;
            int n = numbers.Count;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }
                }
            }
            return sorted;
        }

        public static bool IsTheSunUp(TimeSpan tod)
        {
            return (tod.Hours > 7) && (tod.Hours < 20);
        }
    }
}