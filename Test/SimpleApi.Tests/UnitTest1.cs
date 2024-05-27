using SimpleApi;
namespace SimpleAPI.Tests;

public class UnitTest1
{
    ValuesController objValuesController=new ValuesController(); // arrange
    [Fact]
    public void Test1()
    {

    }
    [Fact]
    public void GetReternedCollectNumner()
    {
       string value= objValuesController.Get(1);
       Assert.Equal("Temp",value);
    }
}