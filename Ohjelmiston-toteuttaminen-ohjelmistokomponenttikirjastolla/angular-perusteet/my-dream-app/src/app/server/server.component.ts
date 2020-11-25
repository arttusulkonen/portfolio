import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-server',
  templateUrl: './server.component.html',
  styleUrls: ['./server.component.css']
})
export class ServerComponent implements OnInit {
  serverId: number = 19;
  serverStatus: string = 'offline';

  getServerStatus(){
    return this.serverStatus;
  }
  getColor(){
    return this.getServerStatus() === 'online' ? 'green' : 'red';
  }
  constructor() {
    this.serverStatus = Math.random() > 0.5 ? 'online' : 'offline';
  }
ngOnInit(): void {
  }

}
