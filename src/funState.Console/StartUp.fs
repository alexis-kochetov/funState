// Learn more about F# at http://fsharp.org
namespace funState

open System
open Microsoft.AspNetCore.Http
open Microsoft.AspNetCore.Hosting
open Microsoft.AspNetCore.Builder

type StartUp() = 
    member this.Configure(app: IApplicationBuilder) = 
        app.Run(fun context -> context.Response.WriteAsync("Hello world!!!"))
        

module Main =
    [<EntryPoint>]
    let main argv = 
        let host = WebHostBuilder().UseKestrel().UseStartup<StartUp>().Build()
        host.Run()
        printfn "Server stopped!"
        
        0 // return an integer exit code
