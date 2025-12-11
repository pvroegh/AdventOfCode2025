using System.ComponentModel;
using System.Diagnostics;

namespace AdventOfCode2025.Code;

public class Day3(string? filename = null) : BaseDay(filename)
{
    public override string Solution1()
    {
        return Input.Sum(Process2).ToString();
    }

    public override string Solution2()
    {
        return Input.Sum(Process12).ToString();
    }
    
    private int Process2(string s)
    {
        var firstLargestDigit = s.Substring(0, s.Length - 1).OrderByDescending(d => int.Parse(d.ToString())).First();
        var firstLargestDigitIndex = s.IndexOf(firstLargestDigit.ToString(), StringComparison.Ordinal);
        var secondLargestDigit = s.Where((c, i) => i > firstLargestDigitIndex)
            .OrderByDescending(d => int.Parse(d.ToString()))
            .First();
        var v = int.Parse($"{firstLargestDigit}{secondLargestDigit}");
        Console.WriteLine($"String: {s}, First largest: {firstLargestDigit}, second largest: {secondLargestDigit}, Value: {v}");
        return v;
    }

    private long Process12(string s)
    {
        // https://adventofcode.com/2025/day/3#part2
        Console.WriteLine();
        var result = new List<char>();
        var firstLargestDigit = s.Substring(0, 3).OrderByDescending(d => int.Parse(d.ToString())).First();
        var firstLargestDigitIndex = s.IndexOf(firstLargestDigit.ToString(), StringComparison.Ordinal);
        result.Add(firstLargestDigit);
        var currentHighestDigitValue = int.Parse(firstLargestDigit.ToString());
        for (var i = 0; i < 10; i++)
        {
            if (firstLargestDigitIndex + 1 + i >= s.Length)
            {
                break;
            }
            var index = i + firstLargestDigitIndex + 1;
            var currentDigit = s[index];
            var currentDigitValue = int.Parse(currentDigit.ToString());
            if (currentDigitValue <= currentHighestDigitValue)
            {
                result.Add(currentDigit);
                currentHighestDigitValue = currentDigitValue;
            }
        }

        if (result.Count < 12)
        {
            var digitsToAdd = 12 - result.Count;
            // Take the last {digitsToAdd} digits from the original string
            var startIndex = s.Length - digitsToAdd;
            result.AddRange(s.Substring(startIndex));
        }

        var concat = string.Concat(result.Select(c => c.ToString()));
        Console.WriteLine(concat);
        return long.Parse(concat);
    }
}
