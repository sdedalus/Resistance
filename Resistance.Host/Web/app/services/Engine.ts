declare var THREE: any;
declare var BandA: Number;
declare var BandB: Number;
declare var BandC: Number;
declare var BandD: Number;

export class Engine {
    public scene: any;
    public camera: any;
    public renderer: any;
    public mesh: any;
    public controls: any;
    public geometry: any;
    public container: any;
    public vector: any;

    constructor(appElement: any) {
        init();
        animate();

        function init() {
            this.container = appElement;
            this.scene = new THREE.Scene();

            this.camera = new THREE.PerspectiveCamera(95, window.innerWidth / window.innerHeight, 0.001, 1500);
            this.camera.position.set(0, 10, 0);

            // add a camera to the scene
            this.scene.add(this.camera);

            this.renderer = new THREE.WebGLRenderer();
            this.renderer.setSize(window.innerWidth, window.innerHeight);
            this.renderer.domElement.style.position = "absolute";
            this.renderer.domElement.style.top = 0;
            this.container.appendChild(this.renderer.domElement);

            this.effect = new THREE.StereoEffect(this.renderer);
            this.effect.eyeSeparation = -1;

            var geometry = new THREE.CylinderGeometry(1, 1, 1);
            var material = new THREE.MeshBasicMaterial({ color: 0xe6ccb3 });
            var baseCilinder = new THREE.Mesh(geometry, material);
            this.scene.add(baseCilinder);
        }
        function animate(t: any = null) {
            requestAnimationFrame(animate);

            this.controls.update();


            this.effect.render(this.scene, this.camera);
        }
    }
}