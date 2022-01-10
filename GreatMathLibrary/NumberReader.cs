
namespace GreatMathLibrary;

public interface IReaderBase
{
    Task<IEnumerable<int>> ReadNumbersAsync();
}

internal class NumberReader : IReaderBase
{
    public async Task<IEnumerable<int>> ReadNumbersAsync()
    {
        var file = await File.ReadAllTextAsync("Numbers.txt");
        return file.Split(',').Select(v => int.Parse(v));
    }

}

