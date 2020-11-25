import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-servers',
  templateUrl: './servers.component.html',
  styleUrls: ['./servers.component.css']
})
export class ServersComponent implements OnInit {
  allowNewServer: boolean = false;
<<<<<<< HEAD
  serverCreationStatus = 'No server was created!';
=======
>>>>>>> 55e8a3fa113e5d7e41c60a6ecf12a6f63d708633

  constructor() {
  setTimeout(() => {
  this.allowNewServer = true;
}, 2000);
}
  ngOnInit(): void {
  }

<<<<<<< HEAD
  onCreateServer(){
    this.serverCreationStatus = 'Server was created!';
  }

=======
>>>>>>> 55e8a3fa113e5d7e41c60a6ecf12a6f63d708633
}
