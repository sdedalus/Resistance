import {Component} from 'angular2/core';
import { ExtendRenderDirective } from './extendRender.directive';
import { ColorSelectionService } from './services/ColorSelectionService';
import { ResistorColorChoices } from './services/ResistorColorChoices';
import { ResistorColor } from './services/ResistorColor'

//import { Engine } from "./services/engine";

//export class Color {
//    id: number;
//    name: string;
//    value: number;
//}

@Component({
    selector: 'resister-app',
    templateUrl: "/views/resistorView.html",
    // registering the ColorSelectionService with DI is just a quick way to get
    // something working and needs to be replaced with a more robust solution.
    providers: [ColorSelectionService],
    directives: [ExtendRenderDirective]
})
export class AppComponent {
    public choices: ResistorColorChoices = new ResistorColorChoices();
    public selection: ColorSelectionService;

    constructor(public colorSelection: ColorSelectionService) {
        this.selection = colorSelection;
        colorSelection.BandA = this.choices.Black;
        colorSelection.BandB = this.choices.Red;
        colorSelection.BandC = this.choices.Red;
        colorSelection.BandD = this.choices.Silver;
    }
}