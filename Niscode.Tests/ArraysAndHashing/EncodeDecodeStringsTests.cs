using Niscode.ArraysAndHashing.EncodeDecodeStrings;

namespace Niscode.Tests.ArraysAndHashing;

public class EncodeDecodeStringsTests
{
    [Theory]
    [MemberData(nameof(GetTestData))]
    public void EncodeDecode_ShouldReturnOriginalStrings(List<string> input)
    {
        var codec = new Solution();
        
        var encoded = codec.Encode(input);
        var decoded = codec.Decode(encoded);
        
        Assert.Equal(input, decoded);
    }

    public static IEnumerable<object[]> GetTestData()
    {
        yield return [new List<string> { "do", "re", "mi", "fa" }];
        yield return [new List<string> { "we", "say", ":", "yes" }];
        yield return [new List<string> { "", "", "" }];
        yield return [new List<string> { "a#b", "1#2#3", "###", "#" }];
        yield return [new List<string> { "multi\nline", "😊", "tabs\tare\there" }];
        yield return [new List<string> { "1", "22", "333", "4444", "55555" }];
        yield return [new List<string>()]; // Empty list
        yield return [new List<string> { "" }]; // Single empty string
    }
}