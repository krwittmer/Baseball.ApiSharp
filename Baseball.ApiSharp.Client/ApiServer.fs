(* Copyright Information *)
(* All source is copyright, Kevin Wittmer *)
(* See License.txt for more information (check Visual Studio Solution Items) *)
(* ================================== *)

module ApiServer

open Microsoft.AspNetCore.Hosting
open Microsoft.Extensions.Hosting
open Baseball.ApiSharp.Api

let CreateHostBuilder args =
    Host.CreateDefaultBuilder(args)
        .ConfigureWebHostDefaults(fun webBuilder ->
            webBuilder.UseStartup<Startup>() |> ignore
        )