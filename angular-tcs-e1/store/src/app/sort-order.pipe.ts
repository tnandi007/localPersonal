import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'sortOrders',
  standalone: true
})
export class SortOrdersPipe implements PipeTransform {
  transform(orders: any[], pickupTimeKey: string): any[] {
    if (!orders || orders.length === 0) {
      return orders;
    }

    return orders.sort((a, b) => {
      const [aHours, aMinutes] = a[pickupTimeKey].split(':').map(Number);
      const [bHours, bMinutes] = b[pickupTimeKey].split(':').map(Number);

      const aDate = new Date();
      aDate.setHours(aHours, aMinutes, 0, 0);

      const bDate = new Date();
      bDate.setHours(bHours, bMinutes, 0, 0);

      return aDate.getTime() - bDate.getTime();
    });
  }
}