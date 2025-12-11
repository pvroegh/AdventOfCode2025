using AdventOfCode2025.Code;

namespace AdventOfCode2025.Tests;

public class Day2Tests
{
    [Fact]
    public void Day2_Solution1()
    {
        var day = new Day2("Day2Test");
        Assert.Equal("1227775554", day.Solution1());
    }

    [Fact]
    public void Day2_Solution2()
    {
        var day = new Day2("Day2Test");
        Assert.Equal("4174379265", day.Solution2());
    }
}