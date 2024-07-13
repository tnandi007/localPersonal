import { CommonModule } from '@angular/common';
import { Component, EventEmitter, Input, OnChanges, Output } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { SumColorPipe } from "../sum-color.pipe";

@Component({
    selector: 'app-add',
    standalone: true,
    templateUrl: './add.component.html',
    styleUrl: './add.component.css',
    imports: [FormsModule, CommonModule, SumColorPipe]
})
export class AddComponent {
  @Input() inputVal: number=0;
  sum: number=0;
  defValue:number=0;
  // @Input() value!: number;
  // @Output() valueChange = new EventEmitter<number>();
  // currentStyles1 = {
  //   'font-style': 'italic',
  //   'font-weight':  'bold',
  //   'font-size': '24px',
  // };
  currentStyles: Record<string, string> = {};

Add(){
this.sum= (5  + this.inputVal);
}
inputChange(){
  if(this.inputVal <0 )
  {
  this.currentStyles = {
    'color': 'red', 
  };
  }
  else if (this.inputVal > 0 ){
  this.currentStyles = {
    'color': 'green', 
  };
  }
  else 
  { this.currentStyles = {
    'color': 'black', 
  };

  }
  
}

}



