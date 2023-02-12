using Xunit;
using MyNewRootLib;

namespace MyNewRootLibTest
{

public class NewUnitTest1
{
    [Fact]
	public void TestPowerRootOf4() {
	
		double a = 2; // arrange
		double expected = 4;
	
		double actual = MyNewRootLib.Root.Power(a); // act
 
		Assert.Equal(expected, actual); // assert
	}	
	[Fact]
    public void TestPowerRootOf9() {
    
		double a = 3; // arrange
		double expected = 9;
	
		double actual = MyNewRootLib.Root.Power(a); // act

		Assert.Equal(expected, actual); // assert
	} 
}
}