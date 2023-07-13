// For more information see https://aka.ms/fsharp-console-apps

open Elmish
open Elmish.React

open StateInit
open BasicView

Program.mkSimple init update view
|> Program.withReactBatched "elmish-app"
|> Program.run
