void FillArray(int[] collection) // void это метод, который не возвращает значения
{
    int length = collection.Length;
    int index = 0;

    while (index < length)
    {
        collection[index] = new Random().Next(1, 10); //аргументу collection на позиции index положить новое целое случайное 
                                                      //число из диапозона 1-10
        index++;
    }
}


void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;

    while (position < count)
    {

     System.Console.WriteLine(col[position]);   
     position++;
    }
}

int IndexOf(int[] collection, int find) // метод индексоф с аргументом -   массив collection и find
{
    int count = collection.Length;
    int index = 0;
    int position = -1; /// договорились присвоить "-1", чтобы оно выводилось, если введено значение find>10

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

int[] array = new int[10]; // Создай новый массив в которм будет 10 элементов (изначально заполнен нулями)

FillArray(array); // метод заполняющий массив
PrintArray(array); // метод выводящий на печть массив
System.Console.WriteLine();

int pos = IndexOf(array, 25);
System.Console.WriteLine(pos);


