﻿Задача:
Создать коллекцию работников и с помощью LINQ-запросов и отсортировать по имени и фамилии тех, у кого зарплата больше 30 000.
Вывести имена и фамилии сотрудников на консоль.

Решение:

+1. Создать класс Employee который будет содержать 4 свойства:
    + Имя
    + Фамилия
    + Зарплата
    + Дата трудоустройства
+2. Создать generic-коллекцию и закрыть ее классом Employee
+3. С помощью LINQ-запросов
    + сделать выборку сотрудников, который получают больше 30 000;
    + отсортировать сотрудников по фамилии и имени;
+4. Циклом foreach вывести сотрудников.
+5. Создать три метода в классе Employee:
    + AddEmployee()
    + SelectEmployee()
    + PrintEmployee()
+6. Добавить Id сотрудника и Id города, в котором живет сотрудник в классе Employee;
+7. Добавить класс Cities и создать справочную коллекцию городов.
+8. Сделать Join Left запрос к двум коллекциям и выбрать из них всех сотрудников и города в которых они проживают.
+9. Вывести список сотрудников и городов на экран.


