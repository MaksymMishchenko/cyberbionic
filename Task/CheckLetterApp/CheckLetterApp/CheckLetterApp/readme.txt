﻿Задача:
Метод IsLower() принимает в качестве аргумента один символ (букву) и возвращает ненулевое целое значение в том случае, если
буква является строчной, и нулевое, если буква является заглавной. Напишите программу, которая
принимает букву от пользователя, а затем выводит нулевое или ненулевое значение в зависимости от того, является ли буква строчной или нет.

Решение:
 + 1. С помощью метода Console.WriteLine() просим пользователя ввести букву.
 + 2. Создаем переменную letter типа char, присваиваем ей с помощью метода Console.ReadLine() букву введенную пользователем. 
 + 3. С помощью конструкции if-else проверяем, действительно ли пользователь вводит букву.
 + 4. В теле класса CheckLetter создаем публичный метод IsLower(), который принимает один параметр - букву.
 + В методе делаем проверку, если буква строчная, то возвращаем ненулевое значение, если заглавная, то нулевое значение.
Выводим результат на экран.  
 + 5. В теле класса Program в методе Main() создаем экземпляр класса CheckLetter. На экземпляре вызываем наш публичный метод IsLower().
 + 6. Пишем тест для метода IsLower().