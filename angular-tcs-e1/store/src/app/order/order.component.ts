import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { HighlightPastPickupDirective } from '../highlight-past-pickup.directive';
import { SortOrdersPipe } from '../sort-order.pipe';

@Component({
  selector: 'app-order',
  standalone: true,
  imports: [CommonModule, HighlightPastPickupDirective,SortOrdersPipe],
  templateUrl: './order.component.html',
  styleUrl: './order.component.css'
})
export class OrderComponent {


toDate(arg0: string): string|number|Date {
const [hours, minutes] = arg0.split(':').map(Number);
const now = new Date();
now.setHours(hours, minutes, 0, 0);
return now.getTime();
// const newDt = new Date(arg0);
// console.log(newDt);
// return new Date(arg0);
}

  orders =[
      { 
        id:1,
        customer: 'ava lumen',
        drink: 'Mocha',
        size: 'M',
        pickupTime: '14:00',
        notes: 'Add vanilla Syrup'
      },
      { 
        id:2,
        customer: 'jasper wren',
        drink: 'Regular Coffee',
        size: 'L',
        pickupTime: '13:00',
        notes: 'Add 2 Creamers and 2 Sugars'
      },
      { 
        id:3,
        customer: 'nina solari',
        drink: 'Cappucinno',
        size: 'L',
        pickupTime: '15:00',
        notes: 'Add 2 shots and cinnamon'
      },
      { 
        id:4,
        customer: 'kei mendoza',
        drink: 'Espresso',
        size: 'S',
        pickupTime: '17:00',
        notes: null
      }

  ]

  markAsPicked(orderId:number){
    this.orders = this.orders.filter(order => order.id !== orderId);
  }

}
