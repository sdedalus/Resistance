import { ResistorColor } from './ResistorColor'
export class ResistorColorChoices {
    public Black: ResistorColor = { "id": 0, "name": "black", "value": 0x000000 };
    public Brown: ResistorColor = { "id": 1, "name": "brown", "value": 0x4b2929 };
    public Red: ResistorColor = { "id": 2, "name": "red", "value": 0xff0000 };
    public Orange: ResistorColor = { "id": 3, "name": "orange", "value": 0xff6a00 };
    public Yellow: ResistorColor = { "id": 4, "name": "yellow", "value": 0xffd800 };
    public Green: ResistorColor = { "id": 5, "name": "green", "value": 0x34ba45 };
    public Blue: ResistorColor = { "id": 6, "name": "blue", "value": 0x0094ff };
    public Violet: ResistorColor = { "id": 7, "name": "violet", "value": 0x6642c2 };
    public Gray: ResistorColor = { "id": 8, "name": "gray", "value": 0x808080 };
    public White: ResistorColor = { "id": 9, "name": "white", "value": 0xffffff };
    public Gold: ResistorColor = { "id": -1, "name": "gold", "value": 0xffc300 };
    public Silver: ResistorColor = { "id": -2, "name": "silver", "value": 0xC0C0C0 };
    public None: ResistorColor = { "id": -3, "name": "none", "value": 0xe6ccb3 };

    public Colors: ResistorColor[] = [
        this.Black,
        this.Brown,
        this.Red,
        this.Orange,
        this.Yellow,
        this.Green,
        this.Blue,
        this.Violet,
        this.Gray,
        this.White,
        this.Gold,
        this.Silver,
        this.None
    ];
}