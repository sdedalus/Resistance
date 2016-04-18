import {Component} from 'angular2/core';
import { ExtendRenderDirective } from './extendRender.directive';
import { ColorSelectionService } from './services/ColorSelectionService'

//import { Engine } from "./services/engine";

//export class Color {
//    id: number;
//    name: string;
//    value: number;
//}

@Component({
    selector: 'resister-app',
    template: "<div class='row' > <div class='span4' extendRender></div> </div>",
    // registering the ColorSelectionService with DI is just a quick way to get
    // something working and needs to be replaced with a more robust solution.
    providers: [ColorSelectionService],
    directives: [ExtendRenderDirective]
})
export class AppComponent {
    constructor() {
        //alert("test");
        //new Engine(document.getElementById("container"));
    }
}