module BasicView

open Fable
open Fable.React

let view model dispatch =
    div [] [ p [] [ str (sprintf "Hello %A" model) ] ]
