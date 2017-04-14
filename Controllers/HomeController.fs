namespace WebApiFsharp.Controllers

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
        ["( ͡° ͜ʖ ͡°)";"(╭☞⌐■v■)╭☞"]

    [<HttpPost>]
    member this.Post([<FromBody>] value: string) =
        this.Ok "(⌐■_■)"

    [<HttpPut("{id}")>]
    member this.Put(id: int, [<FromBody>] value: string) =
        this.Ok "( ͡° ͜つ ͡°)"
    
    [<HttpDelete("id")>]
    member this.Delete(id: int) =
        this.Ok "ಠ_ಠ"