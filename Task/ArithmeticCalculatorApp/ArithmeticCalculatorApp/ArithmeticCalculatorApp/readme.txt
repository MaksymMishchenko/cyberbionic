﻿Задача: 

Создайте эквивалент калькулятора, выполняющего четыре основных арифметических операции.
Программа должна запрашивать ввод пользователем первого операнда, знака операции и второго операнда. 
Для хранения операндов следует использовать переменные вещественного типа. Выбрать операцию можно при помощи оператора switch.
В конце программа должна отображать результат на экране.
Результат работы программы с пользователем может выглядеть следующим образом:
Введите первый операнд, операцию и второй операнд: 10 / 3
Результат равен 3.333333
Выполнить еще одну операцию (y/n)? y
Введите первый операнд, операцию и второй операнд: 12 + 100
Результат равен 112
Выполнить еще одну операцию (y/n)? n

Решение:
- 1. Создаем тесты под методы, которые будут выполнять 5 арифметических действий: умножение, деление, сложение, вычитание, деление с остатком.
- 2. Создаем класс Calculator, в котором создаем 5 методов.
- 3. Создаем модель, которая принимаем от пользователя два операнда и знак операции над ними.
- 4. В классе Program в конструкции Switch case вызываем метод, исходя из выбранного пользователем арифметического действия над операндами


