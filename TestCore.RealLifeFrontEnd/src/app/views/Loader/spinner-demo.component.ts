import { Component, OnInit } from '@angular/core';

const SPINNER_CONFIG = {
  'ball-scale-multiple': {
    divs: 3,
    class: 'sk-ball-scale-multiple'
  },
  'ball-spin': {
    divs: 8,
    class: 'sk-ball-spin'
  },
  'ball-spin-clockwise': {
    divs: 8,
    class: 'sk-ball-spin-clockwise'
  },
  'ball-spin-clockwise-fade-rotating': {
    divs: 8,
    class: 'sk-ball-spin-clockwise-fade-rotating'
  },
  'ball-spin-fade-rotating': {
    divs: 8,
    class: 'sk-ball-spin-fade-rotating'
  },
  'chasing-dots': {
    divs: 2,
    class: 'sk-chasing-dots'
  },
  'circle': {
    divs: 12,
    class: 'sk-circle'
  },
  'cube-grid': {
    divs: 9,
    class: 'sk-cube-grid'
  },
  'double-bounce': {
    divs: 2,
    class: 'sk-double-bounce'
  },
  'fading-circle': {
    divs: 12,
    class: 'sk-fading-circle'
  },
  'folding-cube': {
    divs: 4,
    class: 'sk-folding-cube'
  },
  'pulse':  {
    divs: 1,
    class: 'sk-pulse'
  },
  'rectangle-bounce': {
    divs: 5,
    class: 'sk-rectangle-bounce'
  },
  'rectangle-bounce-party': {
    divs: 5,
    class: 'sk-rectangle-bounce-party'
  },
  'rectangle-bounce-pulse-out': {
    divs: 5,
    class: 'sk-rectangle-bounce-pulse-out'
  },
  'rectangle-bounce-pulse-out-rapid': {
    divs: 5,
    class: 'sk-rectangle-bounce-pulse-out-rapid'
  },
  'rotating-plane': {
    divs: 1,
    class: 'sk-rotating-plane'
  },
  'square-jelly-box': {
    divs: 2,
    class: 'sk-square-jelly-box'
  },
  'square-loader': {
    divs: 1,
    class: 'sk-square-loader'
  },
  'three-bounce': {
    divs: 3,
    class: 'sk-three-bounce'
  },
  'three-strings': {
    divs: 3,
    class: 'sk-three-strings'
  },
  'wandering-cubes': {
    divs: 2,
    class: 'sk-wandering-cubes'
  },
};

@Component({
  selector: 'spinner-demo',
  templateUrl: './spinner-demo.component.html',
  styleUrls: ['./spinner-demo.component.scss']
})
export class SpinnerDemoComponent implements OnInit {
  spinners: any;
  constructor() {
  }

  ngOnInit() {
    this.spinners = Object.keys(SPINNER_CONFIG).map(key => {
      return {
        name: key,
        divs: Array(SPINNER_CONFIG[key].divs).fill(1),
        class: SPINNER_CONFIG[key].class
      }; 
    });
  }
}
