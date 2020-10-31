(* Copyright Information *)
(* All source is copyright, Kevin Wittmer *)
(* See License.txt for more information (check Visual Studio Solution Items) *)
(* ================================== *)

module ApiClient

open Baseball.ApiSharp.Models
open Newtonsoft.Json // get this here = http://james.newtonking.com/json
open RestSharp // get this here = http://restsharp.org/
open System.Collections.Generic

let client = RestSharp.RestClient("http://localhost:5000/")

let GetBatter(batter : string) =
    let request = new RestSharp.RestRequest("api/batters/" + batter, Method.GET)
    let response = client.Execute(request)
    response

let TagBatter(batter : string, tagId : string, tagValue : string) =
    let myTag = new TagModel()
    myTag.TagId <- tagId
    myTag.TagValue <- tagValue
    myTag.DataFieldReferencesAsJson <- "{}"

    let tags = new TagsModel()
    let richTagData = new List<TagModel>()
    richTagData.Add(myTag)
    tags.RichTagData <- richTagData

    let serializedObject = JsonConvert.SerializeObject(tags)
    let request = new RestSharp.RestRequest("api/batters/" + batter + "/tags", Method.PUT)
    let jsonBody = request.AddJsonBody(serializedObject)
    let response = client.Execute(request)
    response
