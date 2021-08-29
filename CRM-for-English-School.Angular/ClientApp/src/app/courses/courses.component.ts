import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'courses',
  templateUrl: './courses.component.html'
})
export class CoursesComponent {
  public courses: Course[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Course[]>(baseUrl + 'courses').subscribe(result => {
      this.courses = result;
    }, error => console.error(error));
  }
}

interface Course {
  Id: number,
  CourseName: string,
  EnglishLevel: EnglishLevel,
  ExpectedStartDate: Date
}

enum EnglishLevel {
  Elementary,
  Pre_Intermediate,
  Intermediate,
  Upper_Intermediate,
  Advanced,
  Proficiency
}
