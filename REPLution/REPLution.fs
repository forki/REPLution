﻿namespace REPLution

open Microsoft.FSharp.Core
open Microsoft.FSharp.Build
open Microsoft.FSharp.Compiler
open Microsoft.FSharp.Compiler.Interactive
open Microsoft.FSharp.Compiler.Interactive.RuntimeHelpers
open Microsoft.FSharp.Compiler.Interactive.Settings


module REPLution =
    let inline (</) f x = x f
    let inline (/>) f x = f x
    
    let startRepl =
        //let shell = new Microsoft.FSharp.Compiler.Interactive.InteractiveSession()
        ()
