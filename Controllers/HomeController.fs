namespace WebApi.FSharp.Controllers

open System
open System.Collections.Generic
open System.Linq
open System.Threading.Tasks
open Microsoft.AspNetCore.Mvc

[<Route("api/[controller]")>]
type HomeController() =
    inherit Controller()

    [<HttpGet>]
    member this.Get() =
        ["value1";"value2"]

    [<HttpPost>]
    member this.Post([<FromBody>] value: string) =
        this.Ok ""

    [<HttpPut("{id}")>]
    member this.Put(id: int, [<FromBody>] value: string) =
        this.Ok ""
    
    [<HttpDelete("id")>]
    member this.Delete(id: int) =
        this.Ok ""