import { Member } from './../../_model/member';
import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'app-member-card',
  templateUrl: './member-card.component.html',
  styleUrls: ['./member-card.component.css'],
  
})
export class MemberCardComponent implements OnInit {
  @Input() member: Member;

  constructor() { }

  ngOnInit(): void {
  }

}
