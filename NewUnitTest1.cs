using Xunit;
using MyPowerLib;

namespace MyPowerLibTest
{

public class NewUnitTest1
{
    [Fact]
	public void TestPowerOf4() {
	
		double a = 2; // arrange
		double expected = 4;
	
		double actual = MyPowerLib.Power.Power(a); // act
 
		Assert.Equal(expected, actual); // assert
	}	
	[Fact]
    public void TestPowerOf9() {
    
		double a = 3; // arrange
		double expected = 9;
	
		double actual = MyPowerLib.Power.Power(a); // act

		Assert.Equal(expected, actual); // assert
	} 
}
}