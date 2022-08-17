// Создание функции/метода заполнения массива

// функция заполнения массива
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index += 1;
    }
}

// функция вывод массива на экран
void ShowArray(int[] coll)
{
    int count = coll.Length;
    int position = 0;
    while (position < coll.Length)
    {
        Console.Write($"{coll[position]} ");
        position += 1;
    }
}

// функция по по поиску и выводу индекса искомового элемента массива
int IndexOf(int[] collection, int found)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if ((collection[index]) == found)
        {
            position = index;
        }
        index += 1;
    }
    return position;
}


//создаем массив под названием array из 10 элементов
int[] array = new int[10];

//Применяем к нему заполнению и выводу на экран указанные функции
FillArray(array);
ShowArray(array);
// пропускаем строку
Console.WriteLine();

//находим искомый элемент с помощью функции
int pos = IndexOf(array, 5);
Console.WriteLine(pos);