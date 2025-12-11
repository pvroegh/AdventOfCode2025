using System.ComponentModel;

namespace AdventOfCode2025.Code;

public class Day2(string? filename = null) : BaseDay(filename)
{
    public override string Solution1()
    {
        var result = 0L;
        var ranges = Input[0].Split(',');
        foreach (var range in ranges)
        {
            var bounds = range.Split('-');
            var start = long.Parse(bounds[0]);
            var end = long.Parse(bounds[1]);
            for (long i = start; i <= end; i++)
            {
                var stringNumber = i.ToString();
                if (stringNumber.Substring(0, stringNumber.Length / 2) == stringNumber.Substring(stringNumber.Length / 2))
                {
                    result += i;
                }
            }
        }

        return result.ToString();
    }

    public override string Solution2()
    {
        var result = 0L;
        var ranges = Input[0].Split(',');
        foreach (var range in ranges)
        {
            var bounds = range.Split('-');
            var start = long.Parse(bounds[0]);
            var end = long.Parse(bounds[1]);
            for (long i = start; i <= end; i++)
            {
                var stringNumber = i.ToString();
                for (int j = 0; j < stringNumber.Length / 2; j++)
                {
                    var currentString = stringNumber.Substring(0, j + 1);
                    var checkString = Repeat(currentString, stringNumber.Length / (j + 1));
                    if (checkString == stringNumber)
                    {
                        Console.WriteLine(checkString);
                        result += i;
                        break;
                    }
                }
            }
        }

        return result.ToString();
    }

    private string Repeat(string s, int n)
    {
        return string.Concat(Enumerable.Repeat(s, n));
    }
}
