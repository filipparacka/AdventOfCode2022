using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2022.Day2
{
    public class Day2
    {
        private readonly List<string> input = FileHelper.ReadFile("Day2/Day2input.txt");

        public (int part1, int part2) Day2Part()
        {
            int part1 = 0;
            int part2 = 0;

            var rounds = new List<Shape>();

            rounds = input.Select(x => new Shape()
            {
                Player1 = ReplaceString(x[0]),
                Player2 = ReplaceString(x[2]),
            }).ToList();

            foreach (var round in rounds)
            {
                var player1 = round.Player1;
                var player2 = round.Player2;

                part1 += (player1 == player2 ? 3 : ((player1 == 3 && player2 == 1 || player1 == 1 && player2 == 2 || player1 == 2 && player2 == 3) ? 6 : 0)) + player2;

                if (player2 == 2)
                {
                    part2 += player1 + 3;
                }
                else if (player2 == 3)
                {
                    part2 += (player1 == 3 ? 1 : (player1 == 1 ? 2 : (player1 == 2 ? 3 : 0))) + 6;
                }
                else
                {
                    part2 += (player1 == 1 ? 3 : (player1 == 2 ? 1 : (player1 == 3 ? 2 : 0)));
                }
            }

            return (part1, part2);
        }

        public int ReplaceString(char value)
        {
            switch (value)
            {
                case 'A': 
                case 'X':
                    return 1;
                case 'B':
                case 'Y':
                    return 2;
                case 'C':
                case 'Z':
                    return 3;
                default:
                    return 0;
            }
        }
    }

    public class Shape
    {
        public int Player1 { get; set; }

        public int Player2 { get; set; }
    }
}
