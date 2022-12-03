using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2022
{
    public static class FileHelper
    {
        public static readonly List<string> input = new();

        public static List<string> ReadFile(string filePath)
        {
            return File.ReadAllLines(filePath).ToList();
        }
    }
}
