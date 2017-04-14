namespace WebApi.FSharp

open System
open System.Collections.Generic
open System.Linq
open System.Threading.Tasks
open Microsoft.AspNetCore.Builder
open Microsoft.AspNetCore.Hosting
open Microsoft.Extensions.Configuration
open Microsoft.Extensions.DependencyInjection
open Microsoft.Extensions.Logging

type Startup private() =
    let mutable configuration: IConfigurationRoot = null
    member this.Configuration
        with get() = configuration
        and private set (value) =
            configuration <- value

    new (env: IHostingEnvironment) as this =
        Startup() then
        let builder = 
            ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional = false, reloadOnChange = true)
                .AddJsonFile(sprintf "appsettings%s.json" env.EnvironmentName, optional = true)
                .AddEnvironmentVariables()
        this.Configuration <- builder.Build()

        // This method gets called by the runtime. Use this method to add services to the container.
    member this.ConfigureServices(services: IServiceCollection) =
        services.AddMvc() |> ignore

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    member this.Configure(app: IApplicationBuilder, env: IHostingEnvironment, loggerFactory: ILoggerFactory) =
        loggerFactory.AddConsole(this.Configuration.GetSection("Logging"))
        |> fun x -> x.AddDebug()
        |> ignore

        app.UseMvc() |> ignore
            