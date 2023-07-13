import { ProgramModule_mkSimple, ProgramModule_run } from "./fable_modules/Fable.Elmish.4.0.0/program.fs.js";
import { Program_withReactBatched } from "./fable_modules/Fable.Elmish.React.4.0.0/react.fs.js";
import { update, init } from "./StateInit.fs.js";
import { view } from "./BasicView.fs.js";

ProgramModule_run(Program_withReactBatched("elmish-app", ProgramModule_mkSimple(init, update, view)));

