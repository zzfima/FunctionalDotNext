module SharpClient

open MathSharp

let minus a b =
    let sharpMath = MathSharpLogic()
    sharpMath.Minus(a, b)