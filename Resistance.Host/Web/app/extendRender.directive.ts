/// <reference path="../typings/main/ambient/three/index.d.ts" />
import { Directive, ElementRef, Input, } from 'angular2/core';
import { ColorSelectionService } from './services/ColorSelectionService';

@Directive({
    selector: '[extendRender]'
})

export class ExtendRenderDirective {
    public scene: THREE.Scene;
    public camera: THREE.Camera;
    public renderer: THREE.Renderer;
    public container: any;

    public resistorBase: THREE.Mesh;
    public resistorWire: THREE.Mesh
    public resistorBandA: THREE.Mesh;
    public resistorBandB: THREE.Mesh;
    public resistorBandC: THREE.Mesh;
    public resistorBandD: THREE.Mesh;

    public materialBandA: THREE.MeshBasicMaterial
    public materialBandB: THREE.MeshBasicMaterial
    public materialBandC: THREE.MeshBasicMaterial
    public materialBandD: THREE.MeshBasicMaterial

    public colors: ColorSelectionService
    public renderWidth: number;
    public renderHeight: number;
    public zRotation: number = Math.PI / 2;
    constructor(public el: ElementRef, public colorSelection: ColorSelectionService) {
        this.colors = colorSelection;
        this.container = el.nativeElement; //.style // it should be possible to detect bootstrap settings on div
        this.renderWidth = this.container.offsetWidth; //this.container.innerWidth
        this.renderHeight = this.renderWidth; // this.container.offsetHeight; //this.container.innerHeight

        this.scene = new THREE.Scene();
        this.camera = new THREE.PerspectiveCamera(75, this.renderWidth / this.renderHeight, 0.1, 1000);
        this.camera.lookAt(new THREE.Vector3(0, 0, 0));
        this.renderer = new THREE.WebGLRenderer();
        //this.renderer.setSize(this.container.innerWidth, this.container.innerHeight);
        this.renderer.setSize(this.renderWidth, this.renderHeight);
        this.container.appendChild(this.renderer.domElement)

        this.createResistorBase();
        this.createResistorWire();
        this.createResistorBandA();
        this.createResistorBandB();
        this.createResistorBandC();
        this.createResistorBandD();

        this.camera.position.z = 5.5;

        this.render();
    }

    createResistorBase() {
        var geometry = new THREE.CylinderGeometry(.25, .25, 2.5, 1000);
        var material = new THREE.MeshBasicMaterial({ color: 0xccccb3 });
        this.resistorBase = new THREE.Mesh(geometry, material);
        this.resistorBase.rotation.z = this.zRotation;
        this.scene.add(this.resistorBase);
    }

    createResistorBandA() {
        var geometry = new THREE.CylinderGeometry(.251, .251, .1, 1000);
        this.materialBandA = new THREE.MeshBasicMaterial({ color: 0xccccb3 });
        this.resistorBandA = new THREE.Mesh(geometry, this.materialBandA);
        this.resistorBandA.position.x = -1;
        this.resistorBandA.rotation.z = this.zRotation;
        this.scene.add(this.resistorBandA);
    }

    createResistorBandB() {
        var geometry = new THREE.CylinderGeometry(.251, .251, .1, 1000);
        this.materialBandB = new THREE.MeshBasicMaterial({ color: 0xccccb3 });
        this.resistorBandB = new THREE.Mesh(geometry, this.materialBandB);
        this.resistorBandB.position.x = -.75;
        this.resistorBandB.rotation.z = this.zRotation;
        this.scene.add(this.resistorBandB);
    }

    createResistorBandC() {
        var geometry = new THREE.CylinderGeometry(.251, .251, .1, 1000);
        this.materialBandC = new THREE.MeshBasicMaterial({ color: 0xccccb3 });
        this.resistorBandC = new THREE.Mesh(geometry, this.materialBandC);
        this.resistorBandC.position.x = -.5;
        this.resistorBandC.rotation.z = this.zRotation;
        this.scene.add(this.resistorBandC);
    }

    createResistorBandD() {
        var geometry = new THREE.CylinderGeometry(.251, .251, .1, 1000);
        this.materialBandD = new THREE.MeshBasicMaterial({ color: 0xccccb3 });
        this.resistorBandD = new THREE.Mesh(geometry, this.materialBandD);
        this.resistorBandD.rotation.z = this.zRotation;
        this.scene.add(this.resistorBandD);
    }

    createResistorWire() {
        var geometry = new THREE.CylinderGeometry(.025, .025, 4, 1000);
        var material = new THREE.MeshBasicMaterial({ color: 0xC0C0C0 });
        this.resistorWire = new THREE.Mesh(geometry, material);
        this.resistorWire.rotation.z = this.zRotation;
        this.scene.add(this.resistorWire);
    }

    rotate() {
        // this just seems to rotate each primitive from it's center rather than from the point of origin.
        this.camera.translateOnAxis(new THREE.Vector3(1, 0, 0), .1);
        this.camera.lookAt(new THREE.Vector3(0, 0, 0));
    }

    resize() {
        this.renderWidth = this.container.offsetWidth;
        this.renderHeight = this.renderWidth; // this.container.offsetHeight; //this.container.innerHeight
        this.renderer.setSize(this.renderWidth, this.renderHeight);
    }

    setColors() {
        if (this.colors != null) {
            if (this.colors.BandA != null) {
                this.materialBandA.color = new THREE.Color(this.colors.BandA.value);
            }
            if (this.colors.BandB != null) {
                this.materialBandB.color = new THREE.Color(this.colors.BandB.value);
            }
            if (this.colors.BandC != null) {
                this.materialBandC.color = new THREE.Color(this.colors.BandC.value);
            }
            if (this.colors.BandD != null) {
                this.materialBandD.color = new THREE.Color(this.colors.BandD.value);
            }
        }
    }

    render() {
        requestAnimationFrame(() => this.render());
        this.rotate();
        this.resize();
        this.setColors();
        this.renderer.render(this.scene, this.camera);
    }
}