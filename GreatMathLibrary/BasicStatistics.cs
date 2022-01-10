namespace GreatMathLibrary;

public class BasicStatistics
{
    private readonly IReaderBase _reader;
    public BasicStatistics(IReaderBase reader)
    {
        this._reader = reader;
    }

    public async Task<int> SumValuesFromReader()
    {
        var reader = new NumberReader();
        var numbers =await reader.ReadNumbersAsync();
        return numbers.Sum();

    }
}

