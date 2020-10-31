(* Copyright Information *)
(* All source is copyright, Kevin Wittmer *)
(* See License.txt for more information (check Visual Studio Solution Items) *)
(* ================================== *)

open ApiServer
open System.Threading
open Baseball.ApiSharp.Dal.Tests

[<EntryPoint>]
let main argv =
    printfn "Launching API client to get Batter data and then tag the data."

    let result = CreateHostBuilder(argv).Build().StartAsync()
    printfn "Launched API server.. pausing a few seconds to let the server fully initialize."
    Thread.Sleep(3000)

    // Pass in batterId exe program argument (e.g., collied02)
    let batterId = argv.[1]
    let getResult = ApiClient.GetBatter(batterId)

    let randomIntegerString= RandomNumberHelper.NextInteger().ToString()
    let newTagId = "tagId " + randomIntegerString
    let newTagValue = "tagValue " + randomIntegerString
    let tagResult = ApiClient.TagBatter(batterId, newTagId, newTagValue)

    printfn "Completed the fetch (get) and then tagging of Batter data."

    0 // return an integer exit code
