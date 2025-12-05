namespace AdventOfCode2025.Code;

public class Day1(string? filename = null) : BaseDay(filename)
{
    public override string Solution1()
    {
        var pointingAtZeroCounter = 0;
        var position = 50;
        foreach (var line in Input)
        {
            var numberOfClicks = int.Parse(line[1..]);
            position += (line[0] == 'R' ? numberOfClicks : -numberOfClicks);
            position %= 100;
            if (position == 0)
            {
                pointingAtZeroCounter++;
            }
        }

        return pointingAtZeroCounter.ToString();
    }

    public override string Solution2()
    {
        var crossingZeroCounter = 0;
        var position = 50;
        foreach (var line in Input)
        {
            var numberOfClicks = int.Parse(line[1..]);
            var offset = (line[0] == 'R' ? numberOfClicks : -numberOfClicks);
            for (int i = 0; i < Math.Abs(numberOfClicks); i++)
            {
                position += offset >= 0 ? 1 : -1;
                crossingZeroCounter += position == 0 ? 1 : 0;
                position = TrueMod;
            }
        }

        return crossingZeroCounter.ToString();
    }
    
    private static int TrueMod(int a, int n) => ((a % n) + n) % n;
}
