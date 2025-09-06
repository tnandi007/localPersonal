import { Directive, ElementRef, Input, OnInit, Renderer2 } from '@angular/core';

@Directive({
  selector: '[appHighlightPastPickup]',
  standalone: true
})
export class HighlightPastPickupDirective implements OnInit {
  @Input() pickupTime!: string; // Input to receive the pickup time

  constructor(private el: ElementRef) {}

  ngOnInit(): void {
    const currentTime = new Date();
    const [pickupHour, pickupMinute] = this.pickupTime.split(':').map(Number);
    const pickupDate = new Date();
    pickupDate.setHours(pickupHour, pickupMinute, 0, 0);

    // Check if the pickup time has passed
    if (pickupDate < currentTime) {
      //this.renderer.setStyle(this.el.nativeElement, 'background-color', '#ffcccc'); // Light red background
      this.el.nativeElement.style='background-color: #ffcccc;'; // Light red background
    }
  }
}