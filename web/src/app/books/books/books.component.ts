import { Component, OnInit } from '@angular/core';
import { Book } from '../book';

@Component({
  selector: 'app-books',
  templateUrl: './books.component.html',
  styleUrls: ['./books.component.css']
})
export class BooksComponent implements OnInit {
  books: Book[] = [
    {
      Id: 1,
      title: "Ready Plyaer One",
      author: "Ernest Cline"

    },
    {
      Id: 2,
      title: "Catch 22",
      author: "Joseph Heller"
    }
  ];

  constructor() { }

  ngOnInit() {
  }

}
