

namespace MyFirstUnitTest;

public class TestBasicMath
{
    [Fact]
    public void Add()
    {
        var result = BasicMath.Add(1, 2);
        Assert.Equal(3,result);
    }

    [Theory]
    [InlineData(1,2,3)]
    [InlineData(10000, 20000, 30000)]
    public void Test2(int x, int y, int expected)
    {
        var result = BasicMath.Add(x, y);
        Assert.Equal(expected,result);

    }


}
