using static CalculationArea.CalculationAreaService;
using static System.Math;

namespace CalculationArea.Tests;

public class CalculationAreaServiceTest
{
	[Fact]
	public void TestForCircle1()
	{
		//Arrange

		var service = new CalculationAreaService();
		var circle = new Circle(10d);
		var expended = 314.1592653589793d;

		//Act
		var result = service.Calculate(circle);

		var absEquals = Abs(result - expended) < double.Epsilon;

		//Assert
		Assert.True(absEquals, $"Expected: {expended} Actual: {result}");
	}

	[Fact]
	public void TestForCircle2()
	{
		//Arrange

		var service = new CalculationAreaService();
		var circle = new Circle(77.5d);
		var expended = 18869.190875623695d;

		//Act
		var result = service.Calculate(circle);

		var absEquals = Abs(result - expended) < double.Epsilon;

		//Assert
		Assert.True(absEquals, $"Expected: {expended} Actual: {result}");
	}

	[Fact]
	public void TestForTriangle1()
	{
		//Arrange

		var service = new CalculationAreaService();
		var triagle = new Triangle(10, 20, 15);
		var expended = 72.61843774138907d;

		//Act
		var result = service.Calculate(triagle);

		var absEquals = Abs(result - expended) < double.Epsilon;

		//Assert
		Assert.True(absEquals, $"Expected: {expended} Actual: {result}");
	}

	[Fact]
	public void TestForTriangle2()
	{
		//Arrange

		var service = new CalculationAreaService();
		var triagle = new Triangle(3, 4, 5);
		var expended = 6d;

		//Act
		var result = service.Calculate(triagle);

		var absEquals = Abs(result - expended) < double.Epsilon;

		//Assert
		Assert.True(absEquals, $"Expected: {expended} Actual: {result}");
	}
}