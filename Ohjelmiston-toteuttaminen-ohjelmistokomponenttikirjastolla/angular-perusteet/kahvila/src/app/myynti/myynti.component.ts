import {Component, Input} from '@angular/core';
import {faCoffee} from '@fortawesome/free-solid-svg-icons';

@Component({
  selector: 'app-myynti',
  templateUrl: './myynti.component.html',
  styleUrls: ['./myynti.component.css']
})
export class MyyntiComponent {

  faCoffee = faCoffee;
  @Input('tarjoilijalle') ohje: { tyo: string, poydanNumero: string, myyntiMaara: string };

}
