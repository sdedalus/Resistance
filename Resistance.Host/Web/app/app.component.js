System.register(['angular2/core', "./services/engine"], function(exports_1, context_1) {
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
    var core_1, engine_1;
    var Color, AppComponent, COLORS;
    return {
        setters:[
            function (core_1_1) {
                core_1 = core_1_1;
            },
            function (engine_1_1) {
                engine_1 = engine_1_1;
            }],
        execute: function() {
            Color = (function () {
                function Color() {
                }
                return Color;
            }());
            exports_1("Color", Color);
            AppComponent = (function () {
                function AppComponent() {
                    new engine_1.Engine(document.getElementById("container"));
                }
                AppComponent = __decorate([
                    core_1.Component({
                        selector: 'my-app',
                        templateUrl: '../views/myfirst.html'
                    }), 
                    __metadata('design:paramtypes', [])
                ], AppComponent);
                return AppComponent;
            }());
            exports_1("AppComponent", AppComponent);
            COLORS = [
                { "id": 0, "name": "black", "value": 0x000000 },
                { "id": 1, "name": "brown", "value": 0x4b2929 },
                { "id": 2, "name": "red", "value": 0xff0000 },
                { "id": 3, "name": "orange", "value": 0xff6a00 },
                { "id": 4, "name": "yellow", "value": 0xffd800 },
                { "id": 5, "name": "green", "value": 0x34ba45 },
                { "id": 6, "name": "blue", "value": 0x0094ff },
                { "id": 7, "name": "violet", "value": 0x6642c2 },
                { "id": 8, "name": "gray", "value": 0x808080 },
                { "id": 9, "name": "white", "value": 0xffffff },
                { "id": -1, "name": "gold", "value": 0xffc300 },
                { "id": -2, "name": "silver", "value": 0xC0C0C0 },
                { "id": -3, "name": "none", "value": 0xe6ccb3 }
            ];
        }
    }
});
//# sourceMappingURL=app.component.js.map