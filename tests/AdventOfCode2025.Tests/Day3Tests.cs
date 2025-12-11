using AdventOfCode2025.Code;

namespace AdventOfCode2025.Tests;

public class Day3Tests
{
    [Fact]
    public void Day3_Solution1()
    {
        var day = new Day3("Day3Test");
        Assert.Equal("357", day.Solution1());
    }

    [Fact]
    public void Day3_Solution2()
    {
        var day = new Day3("Day3Test");
        Assert.Equal("3121910778619", day.Solution2());
    }
}