# Решение задачи

## Вариант 1 (TaskVar1).
Решение оформлено с помощью методов. С клавиатуры вводится длина исходного массива, затем сам массив по индексам. Тип string позволяет ввести значение длины каждого отдельного элемента. При условии соответсвия заданным параметрам элементы из исходного массива перезаписываются в итоговый массив, длина для которого задается как длина исходного массива.

## Вариант 2 (TaskVar2).
Решение также оформлено с помощью методов. С клавиатуры вводится длина исходного массива, затем сам массив по индексам. Тип string позволяет ввести значение длины каждого отдельного элемента массива. В этом варианте я ввела метод подсчета количества элементов, удовлетворяющих условиям поиска. Полученное количество в дальнейшем задается как длина итогового массива и используется для метода проверки исходного массива на наличие соответствующих условиям поиска элементов. Так можно вывести строку с указанием несоответствия исходного массива вместо пустой строки (красивее выглядит)..

## Блок-схема.
![блок-схема](flowchart.jpg)

ArrayA - исходный массив.

ArrayB - итоговый массив.

size - это размер/длина массива А, он же задается и для массива В.

size.arrayA[index] = arrayA[index].length - размер/длина каждого отдельного элемента в массиве А.

indexA - индексы элементов массива А.

indexB - индексы элементов массива В.

