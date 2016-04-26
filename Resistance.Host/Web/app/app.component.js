System.register(['angular2/core', './extendRender.directive', './services/ColorSelectionService', './services/ResistorColorChoices'], function(exports_1, context_1) {
    "use strict";
    var __moduleName = context_1 && context_1.id;
    var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
        var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
        if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
        else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
        return c > 3 && r && Object.defineProperty(target, key, r), r;
    };
    var __metadata = (this && this.__metadata) || function (k, v) {
        if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
    };
    var core_1, extendRender_directive_1, ColorSelectionService_1, ResistorColorChoices_1;
    var AppComponent;
    return {
        setters:[
            function (core_1_1) {
                core_1 = core_1_1;
            },
            function (extendRender_directive_1_1) {
                extendRender_directive_1 = extendRender_directive_1_1;
            },
            function (ColorSelectionService_1_1) {
                ColorSelectionService_1 = ColorSelectionService_1_1;
            },
            function (ResistorColorChoices_1_1) {
                ResistorColorChoices_1 = ResistorColorChoices_1_1;
            }],
        execute: function() {
            //import { Engine } from "./services/engine";
            //export class Color {
            //    id: number;
            //    name: string;
            //    value: number;
            //}
            AppComponent = (function () {
                function AppComponent(colorSelection) {
                    this.colorSelection = colorSelection;
                    this.choices = new ResistorColorChoices_1.ResistorColorChoices();
                    this.selection = colorSelection;
                    colorSelection.BandA = this.choices.Black;
                    colorSelection.BandB = this.choices.Red;
                    colorSelection.BandC = this.choices.Red;
                    colorSelection.BandD = this.choices.Silver;
                }
                AppComponent = __decorate([
                    core_1.Component({
                        selector: 'resister-app',
                        templateUrl: "/views/resistorView.html",
                        // registering the ColorSelectionService with DI is just a quick way to get
                        // something working and needs to be replaced with a more robust solution.
                        providers: [ColorSelectionService_1.ColorSelectionService],
                        directives: [extendRender_directive_1.ExtendRenderDirective]
                    }), 
                    __metadata('design:paramtypes', [ColorSelectionService_1.ColorSelectionService])
                ], AppComponent);
                return AppComponent;
            }());
            exports_1("AppComponent", AppComponent);
        }
    }
});
//# sourceMappingURL=app.component.js.map