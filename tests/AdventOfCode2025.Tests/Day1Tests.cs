using AdventOfCode2025.Code;

namespace AdventOfCode2025.Tests;

public class Day1Tests
{
    [Fact]
    public void Day1_Solution1()
    {
        var day = new Day1("Day1Test");
        Assert.Equal("3", day.Solution1());
    }

    [Fact]
    public void Day1_Solution2()
    {
        var day = new Day1("Day1Test");
        Assert.Equal("6", day.Solution2());
    }
}