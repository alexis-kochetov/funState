// Learn more about F# at http://fsharp.org

open System
open Microsoft.AspNetCore.Hosting
open Microsoft.AspNetCore.Builder
open Microsoft.AspNetCore.Hosting
open Microsoft.AspNetCore.Http

type Startup() = 
    member this.Configure(app: IApplicationBuilder) = 
        app.Run(fun context -> context.Response.WriteAsync("Hello world!!!"))
        

[<EntryPoint>]
let main argv = 
    let host = WebHostBuilder().UseKestrel().UseStartup<Startup>().Build()
    host.Run()
    printfn "Server stopped!"
        
    0 // return an integer exit code
