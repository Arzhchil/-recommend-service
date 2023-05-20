import { Component, OnInit } from '@angular/core';


@Component({
  selector: 'app-catalog-page',
  templateUrl: './catalog-page.component.html',
  styleUrls: ['./catalog-page.component.scss']

})
export class CatalogPageComponent {
  searchText: any

  works = [
    { id: 0, name: "Футбол" },
    { id: 1, name: "Баскетбол" },
    { id: 2, name: "Волейбол" }
  ];

  format = [
    { id: 0, name: "Очный" },
    { id: 1, name: "Дистант" },
  ];

  days = [
    { id: 0, name: "Понедельник" },
    { id: 1, name: "Вторник" },
    { id: 2, name: "Среда" },
    { id: 3, name: "Четверг" },
    { id: 4, name: "Пятница" },
    { id: 5, name: "Суббота" },
    { id: 6, name: "Воскресенье" },
  ];

  times = [
    { id: 0, name: "9:15" },
    { id: 1, name: "11:15" },
    { id: 2, name: "13:15" },
    { id: 3, name: "15:15" },
    { id: 4, name: "17:15" },
  ];

  English_language = [
    {
      title: "Образование",
      name: "Английский язык",
      filters: ["Очный формат", "Группа занимается", "Запись продолжается"],
      address: "город Москва, улица Мусы Джалия, дом 25А",
      group: "G-02069387",
      day: "Вт",
      start_time: "11:35",
      end_time: "13:15"
    }
  ];

  Walk = [
    {
      title: "Здоровье",
      name: "Скандинавская ходьба",
      filters: ["Очный формат", "Группа занимается", "Запись окончена"],
      address: "город Москва, улица Мусы Джалия, дом 2В",
      group: "A-04067787",
      day: "Ср",
      start_time: "9:35",
      end_time: "10:15"
    }
  ]

  Drive = [
    {
      title: "Дополнительное образование",
      name: "Уроки вождения",
      filters: ["Очный формат", "Группа занимается", "Запись не начиналась"],
      address: "город Москва, улица Мусы Джалия, дом 17",
      group: "D-05586687",
      day: "Сб",
      start_time: "13:35",
      end_time: "14:35"
    }
  ]

  itemSelected(e: any) {
    console.log(e);
  }
}


