namespace CalculationArea.FSharp

module CalculationAreaService =

    type Shape =
        | Circle of radius : float
        | Triangle of SideA : float * SideB : float * SideC : float


    open type System.Math;
    let Calculate shape =
        match shape with
        |Circle radius -> PI * radius ** 2
        |Triangle(sideA, sideB, sideC) -> 
            let sides = [|sideA; sideB; sideC|]
            let maxSide = Seq.max sides
            let cathetus = Seq.toArray (Seq.where (fun(x) -> x <> maxSide) sides)
            let isRightTriangle = maxSide ** 2 = (Seq.sum (Seq.map (fun(x) ->  x ** 2) cathetus))
            if isRightTriangle then cathetus[0] * cathetus[1] / 2.0
            else 
                let semi_perimeter = (sideA + sideB + sideC) / 2.0;
                Sqrt(semi_perimeter * (semi_perimeter - sideA) * (semi_perimeter - sideB) * (semi_perimeter - sideC))


