
open System


let from whom =
    sprintf "from %s" whom

[<EntryPoint>]
let main argv =
    let todayWeather = "sunny"
    let weatherIds = [
    {| id = 0; state = "sunny" |};
    {| id = 1; state = "cloudy" |};
    {| id = 2; state = "rainy" |}
    ]
    let daysToCalc = 7
    let sunny = [| 0.6; 0.3; 0.1 |]
    let cloudy = [| 0.4; 0.4; 0.2 |]
    let rainy = [| 0.2; 0.4; 0.4 |]
    
    let mutable XnOdds = []
    let mutable XNextStates = []
    for i = 0 to weatherIds.Length - 1 do
       if weatherIds.[i].state = todayWeather then
        XnOdds <- XnOdds @ [1]
       else
        XnOdds <- XnOdds @ [0]
    
    XNextStates <- [XnOdds]
    
    for i = 0 to daysToCalc - 1 do
        let lastState = List.last XNextStates
        let mutable XnState = []
        for j = 0 to lastState.Length - 1 do
        XnState <- XnState @ [lastState.[j] * (match weatherIds.[j].state with
        | "sunny" -> sunny.[j]
        | "cloudy" -> cloudy.[j]
        | "rainy" -> rainy.[j]
        | _ -> failwith "Invalid weather state")]
        XNextStates <- XNextStates @ [XnState]
    
    printfn "%A" XNextStates