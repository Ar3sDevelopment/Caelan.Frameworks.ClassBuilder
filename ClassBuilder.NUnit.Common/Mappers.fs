﻿namespace ClassBuilder.NUnit.Common

open ClassBuilder.Classes
open Classes

module Mappers = 
    type ABMapper() = 
        inherit DefaultMapper<TestA, TestB>()
        override __.CustomMap(source, dest) = 
            base.CustomMap(source, dest) |> ignore
            dest.B <- dest.B + " mapper"
            dest
    
    type IntFloatMapper() = 
        inherit DefaultMapper<int, float>()
        override __.CustomMap(source, dest) = 
            base.CustomMap(source, dest) |> ignore
            (float) source