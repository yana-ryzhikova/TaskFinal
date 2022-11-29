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

string [] ArrayStringElements(int len) //Заполнение массива элементами
{
string []array = new string[len];
for (int i = 0; i < array.Length; i++)
{
    array[i] = Prompt($"Введите элемент массива под индексом [{i}] -> ");
}
return array;
}

void PrintArray(string[] array)  //Вывод массива
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}\t");
    }
    System.Console.WriteLine();
}

int CountElements(string[] array) //Считает количество элементов <= 3
{
    int count = 0;
    string[] arr = new string[count];
    for (int i = 0; i < array.Length; i++)
        if (array[i].Length <= 3)
        {
            count++;
        }
    return count;
}


int lengthArray = InputSize($"Введите размер исходного массива элементов -> ");
Console.WriteLine();
string[] myArray = ArrayStringElements(lengthArray);
Console.WriteLine();
Console.WriteLine($"Исходный массив: ");
PrintArray(myArray);
Console.WriteLine();
int count = CountElements(myArray);


string[] ResultArray(string[] array, int count) // Определяет массив из элементов <= 3
{
    count = CountElements(myArray);
    string[] arr = new string[count];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            arr[j] = array[i];
            j++;
        }
    }
    return arr;
}

bool ValidateCount(int count) // проверяет массив на наличие заданных элементов
{
    if (count != 0)
    {
        return true;
    }
    return false;
}

if (ValidateCount(count)) //Вывод массива после проверки
{
    Console.WriteLine($"Итоговый массив элементов ->");
    PrintArray(ResultArray(myArray, count));
}
else
{
    Console.WriteLine($"Все элементы исходного массива не удовлетворяют поиску!");
}