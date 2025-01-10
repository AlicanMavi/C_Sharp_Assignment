using Business.Helpers;

namespace Test.Helpers;

public class IdGenerator_Tests
{
    [Fact]
    public void Generate_ShouldReturnGuidAsString()
    {
        //act
        var result = IdGenerator.Generate();


        //assert
        Assert.NotNull(result);
        Assert.True(Guid.TryParse(result, out _));
    }
}
