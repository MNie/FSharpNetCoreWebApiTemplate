namespace WebApiFsharp

open System.IO
open Microsoft.AspNetCore.Hosting

module Program =
    [<EntryPoint>]
    let main argv =
        WebHostBuilder()
            .UseKestrel()
            .UseContentRoot(Directory.GetCurrentDirectory())
            .UseIISIntegration()
            .UseStartup<Startup>()
            .Build()
            .Run()
        0
