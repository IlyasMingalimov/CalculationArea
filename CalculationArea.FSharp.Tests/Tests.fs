namespace CalculationArea.FSharp.Tests

open Xunit
open CalculationArea.FSharp.CalculationAreaService
open type System.Math
open type System.Double
module CalculationAreaServiceTest =

    [<Fact>]
    let ``Test For Circle 1`` () =
        //Arrange
        let circle = Circle(radius = 10.0)
        let expended = 314.1592653589793;

        //Act
        let result = Calculate circle
        let absEquals = Abs (result - expended)  < Epsilon;

        //Assert
        Assert.True(absEquals, $"Expected: {expended} Actual: {result}")

    [<Fact>]
    let ``Test For Circle 2`` () =
        //Arrange
        let circle = Circle(radius = 77.5)
        let expended = 18869.190875623695;

        //Act
        let result = Calculate circle
        let absEquals = Abs (result - expended)  < Epsilon;

        //Assert
        Assert.True(absEquals, $"Expected: {expended} Actual: {result}")

    [<Fact>]
    let ``Test For Triangle 1`` () =
        //Arrange
        let circle = Triangle(SideA = 10, SideB = 20, SideC = 15)
        let expended = 72.61843774138907;

        //Act
        let result = Calculate circle
        let absEquals = Abs (result - expended)  < Epsilon;

        //Assert
        Assert.True(absEquals, $"Expected: {expended} Actual: {result}")

    [<Fact>]
    let ``Test For Triangle 2`` () =
        //Arrange
        let circle = Triangle(SideA = 3, SideB = 4, SideC = 5)
        let expended = 6.0;

        //Act
        let result = Calculate circle
        let absEquals = Abs (result - expended)  < Epsilon;

        //Assert
        Assert.True(absEquals, $"Expected: {expended} Actual: {result}")

