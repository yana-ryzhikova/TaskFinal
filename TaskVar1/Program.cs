// Задать массив строк: слова и цифры. Вывести из массива массив только с теми
// значениями, которые равны либо не превышают три символа.
// не использовать коллекции, а только массивы.
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []

int InputSize(string message)  // ввод длины массива
{
    System.Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

string Prompt(string message)  // ввод элементов массива
{
    System.Console.Write(message);
    string element = Console.ReadLine();
    return element;
}

void PrintArray(string[] array)  //Вывод массива
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}\t");
    }
    System.Console.WriteLine();
}


string [] ArrayStringElements(int len) //Заполнение массива элементами
{
string []array = new string[len];
for (int i = 0; i < array.Length; i++)
{
    array[i] = Prompt($"Введите элемент массива под индексом [{i}] -> ");
}
return array;
}

int lengthArray = InputSize($"Введите размер исходного массива элементов -> ");
Console.WriteLine();
string[] myArray = ArrayStringElements(lengthArray);
Console.WriteLine();
Console.WriteLine($"Исходный массив: ");
PrintArray(myArray);
Console.WriteLine();
Console.WriteLine($"Итоговый массив: ");

string [] ResultArray(string [] array) // Определяет массив из элементов <= 3
{
string[] arr = new string [array.Length];
int j = 0;
for (int i = 0; i < array.Length; i++)
{
if (array[i].Length <=3 )
        {
          arr[j] = array[i];
          j++;
        }
}
return arr;
}

PrintArray(ResultArray(myArray));