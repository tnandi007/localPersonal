import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'sumColor',
  standalone: true
})
export class SumColorPipe implements PipeTransform {

  // transform(value: unknown, ...args: unknown[]): unknown {
  //   return null;
  // }
  transform(value: number): string {
    if (value < 0) {
      return 'red';
    }
    return 'black';
  }

}
