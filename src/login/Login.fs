namespace App

open Feliz

module Login =

    let private Header () =
        Html.div
            [ prop.className "sm:mx-auto sm:w-full sm:max-w-sm"
              prop.children
                  [ Html.h2
                        [ prop.className "mt-10 text-center text-2xl font-bold leading-9 tracking-tight text-white"
                          prop.children [ Html.text "Sign in to your account" ] ] ] ]

    [<ReactComponent>]
    let Login () =

        Html.div
            [ prop.className "flex min-h-full flex-1 flex-col justify-center px-6 py-12 lg:px-8"
              prop.children [ Header() ] ]
