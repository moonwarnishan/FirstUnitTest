

namespace MyFirstUnitTest;

public class TestBasicSTatistics
{
    [Fact]
    public async Task SumValueForReader()
    {
        var stat = new BasicStatistics(new NumberReader());
        var result=await stat.SumValuesFromReader();
        Assert.Equal(55,result);
    }


}
