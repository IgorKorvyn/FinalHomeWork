Задача:
Написать программу, которая из имеющегося массива строк 
формирует новый массив из строк, длина которых меньше, 
либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма.
При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.

Примеры: 
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []

Алгоритм:
Содаем и заполняем строковый массив рандомными значениями.
Определяем количество элементов в данном массиве, 
длина которых меньше, либо равна 3 символам. 
Это количество будет определять размер нового массива 
для переноса элементов.
Создаем новый массив определенной ранее длины, заполняем 
его значениями по тому же условию (длина элементов 
из начального массива меньше, либо равна 3 символам)
Выводим результаты переноса элементов из первоначального 
строкового массива в новый строковый массив, 
согласно условию задачи.