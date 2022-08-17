/ Создание функции/метода заполнения массива

// функция заполнения массива
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 30);
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
        Console.WriteLine(coll[position]);
        position += 1;
    }
}

//создаем массив под названием array из 10 элементов
int[] array = new int[10];

//Применяем к нему заполнению и выводу на экран указанные функции
FillArray(array);
ShowArray(array);
