namespace AdventOfCode2022
{
    public class Day1
    {
        private readonly List<string> input = FileHelper.ReadFile("Day1/Day1input.txt");

        public int Day1Part1()
        {
            int sum = 0;
            int result = 0;
            foreach (var item in input)
            {
                if (item != String.Empty)
                {
                    sum += Convert.ToInt32(item);
                }
                else
                {
                    result = sum > result ? sum : result;
                    sum = 0;
                }
            }

            return result;
        }

        public int Day1Part2()
        {
            int sum = 0;
            int result = 0;
            List<int> calories = new();

            foreach (var item in input)
            {
                if (item != String.Empty)
                {
                    sum += Convert.ToInt32(item);
                }
                else
                {
                    calories.Add(sum);
                    sum = 0;
                }
            }

            result = calories.OrderByDescending(x => x).Take(3).Sum();

            return result;
        }

        
    }
}