using static System.Math;

namespace CalculationArea;

public class CalculationAreaService
{
	public record ShapeBase();
	public record Circle(double Radius) : ShapeBase;
	public record Triangle(double SideA, double SideB, double SideC) : ShapeBase;

	public double Calculate<Shape>(Shape shape) where Shape : ShapeBase => shape switch
	{
		Circle circle => CalculateAreaForCircle(circle.Radius),
		Triangle triangle => CalculateAreaForTriangle(triangle.SideA, triangle.SideB, triangle.SideC),
		_ => throw new NotImplementedException()
	};

	private double CalculateAreaForCircle(double radius) => PI * Pow(radius, 2d);
	private double CalculateAreaForTriangle(double sideA, double sideB, double sideC)
	{
		var sides = new[] { sideA, sideB, sideC };
		var maxSide = sides.Max(s => s);
		var cathetus = sides.Where(x => x != maxSide).ToArray();
		var isRightTriangle = Pow(maxSide, 2) == cathetus.Select(x => Pow(x, 2d)).Sum(x => x);

		if (isRightTriangle) 
		{
			return cathetus[0] * cathetus[1] / 2;
		}
		else
		{
			var semi_perimeter = (sideA + sideB + sideC) / 2;
			return Sqrt(semi_perimeter * (semi_perimeter - sideA) * (semi_perimeter - sideB) * (semi_perimeter - sideC));
		}
	}
}