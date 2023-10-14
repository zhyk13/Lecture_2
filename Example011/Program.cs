int[] array = new int[10]; // Создает новый массив в котором будет 10 элементов (по умолчанию все они будут 0)
void FillArray(int[] collection) // void - это метод, который ни чего не возвращает
{
    int Length = collection.Length; //Этот метод заполняет массив случайными цислами от 1 до 10
    int index = 0;
    while (index < Length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col) //Этот метод распечатывает массив
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find) //Этот метод возвращает номер искомого элемента
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

FillArray(array);
PrintArray(array);

Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);
