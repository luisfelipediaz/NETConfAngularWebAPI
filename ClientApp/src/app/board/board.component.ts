import { Component, OnInit } from '@angular/core';
import { Tasks, Task, TasksGrouped } from '../task';
import { Observable, of } from 'rxjs';
import { switchMap, map } from 'rxjs/operators';
import { State } from '../state.enum';
import { TasksService } from '../tasks.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-board',
  templateUrl: './board.component.html',
  styleUrls: ['./board.component.scss']
})
export class BoardComponent implements OnInit {
  tasks$: Observable<TasksGrouped>;

  constructor(
    private tasksService: TasksService,

  ) { }

  ngOnInit() {
    this.loadTasks();
  }

  reload() {
    this.loadTasks();
  }

  private loadTasks() {
    this.tasks$ = this.tasksService.getGrouped();
  }

}
