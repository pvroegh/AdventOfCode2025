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
            for (var i = 0; i < numberOfClicks; i++)
            {
                if (line[0] == 'R')
                {
                    position++;
                    position %= 100;
                    if (position == 0) crossingZeroCounter++;
                }
                else
                {
                    position--;
                    if (position == -1) position = 99;
                    if (position == 0) crossingZeroCounter++;
                }
            }
        }

        return crossingZeroCounter.ToString();
    }
}
