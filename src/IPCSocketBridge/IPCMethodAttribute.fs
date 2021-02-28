namespace IPCSocketBridge

open System
open System.Runtime.CompilerServices
open System.Runtime.InteropServices

[<AttributeUsage(AttributeTargets.Method)>]
type IPCMethodAttribute([<CallerMemberName; Optional; DefaultParameterValue("")>]name: string) = 
    inherit Attribute()
    member this.Name = name
 