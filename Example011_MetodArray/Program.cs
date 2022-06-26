int[] array = {15, 22, 36, 41, 507, 68, 74, 80, 36};

int n = array.Length; // n присваивается размерность массива
int find = 36;
int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        System.Console.WriteLine(index);
        break; // прерви, отсанови
    }
    index++; // index = index + 1
}
