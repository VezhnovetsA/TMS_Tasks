using System.Drawing;

Console.WriteLine("Задание: Четный массив");
Console.WriteLine("\tНапишите метод, который создает массив длинной count элементов,\n\tсодержащий последовательные четные числа в порядке возрастания.\n\n\tНапример, GetFirstEvenNumbers(3) должен вернуть массив 2, 4, 6\n");


static int[] GetFirstEvenNumbers(int count)
{
    int[] array = new int[count];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = (i + 1) * 2;
    }

    foreach (int elem in array)
    {
        Console.WriteLine(elem);
    }

    return array;
}

GetFirstEvenNumbers(3);

////////////////////////////////////////////////////////////////////////////////////////////////////////

Console.WriteLine("\n\nЗадание: Индекс максимума");
Console.WriteLine("\tНаписать метод поиска индекса максимального элемента.\n\tТо есть такого числа i, что array[i] — это максимальное из чисел в массиве.\n\tЕсли в массиве максимальный элемент встречается несколько раз, вывести нужно минимальный индекс.\n\tЕсли массив пуст, вывести нужно -1.\n");


static int MaxIndex(double[] array)
{
    int maxIndex = -1;
    double maxValue = double.MinValue;


    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > maxValue)
        {
            maxValue = array[i];
            maxIndex = i;
        }
    }

    if (array.Length == 0)
    {
        return -1;
    }

    else
    {
        return maxIndex;
    }
}


var arr = new double[4];

arr[0] = 2384;
arr[1] = 2374;
arr[2] = 3949;
arr[3] = 1234;

double[] arr2 = new double[0];

Console.WriteLine("Результат заполненного массива: " + MaxIndex(arr));
Console.WriteLine("Результат пустого массива: " + MaxIndex(arr2));

////////////////////////////////////////////////////////////////////////////////////////////////////////

Console.WriteLine("\n\nЗадание: Подсчет");
Console.WriteLine("\tНайти количество вхождений заданного числа в массив чисел.\n\tНапример, в массиве 1, 2, 1, 1 число 1 встречается 3 раза.\n");

static int GetElementCount(int[] items, int itemToCount)
{
    int count = 0;

    foreach (int item in items)
    {
        if (item == itemToCount)
        {
            count++;
        }
    }
    return count;

}

var arr3 = new int[] { 1, 5, 5, 9, 3, 5, 7, 0 };

Console.WriteLine("Подсчет количества вхождений числа 5 в масииве { 1, 5, 5, 9, 3, 5, 7, 0 }: " + GetElementCount(arr3, 5));

////////////////////////////////////////////////////////////////////////////////////////////////////////
///
Console.WriteLine("\n\nЗадание: Поиск массива в массиве\n");

static int FindSubarrayStartIndex(int[] array, int[] subArray)
{
    for (var i = 0; i < array.Length - subArray.Length + 1; i++)
        if (ContainsAtIndex(array, subArray, i))
            return i;
    return -1;
}

static bool ContainsAtIndex(int[] array, int[] subArray, int k)
{
    bool isCorrect = false;
    for (int i = 0; i < subArray.Length; i++)
    {
        if (subArray[i] == array[i + k]) isCorrect = true;
        else return false;

    }

    if (subArray.Length == 0) return true;
    else return isCorrect;
}

var a1 = new int[] { 1, 2, 3 };
var a2 = new int[] { };

Console.WriteLine(ContainsAtIndex(a1, a2, 2));
Console.WriteLine(FindSubarrayStartIndex(a1, a2));


///////////////////////////////////////////////////////////////////////////////////////////////////////

Console.WriteLine("\n\nЗадание: Карты Таро\n");
static string GetSuit(Suits suit)
{
    return new string[] { "жезлов", "монет", "кубков", "мечей" }[Convert.ToInt32(suit)];
}


Console.WriteLine(GetSuit(Suits.Wands));
Console.WriteLine(GetSuit(Suits.Coins));
Console.WriteLine(GetSuit(Suits.Cups));
Console.WriteLine(GetSuit(Suits.Swords));



///////////////////////////////////////////////////////////////////////////////////////////////////////

Console.WriteLine("\n\nЗадание: Null или не Null?\n");

static bool CheckFirstElement(int[] array)
{
    if (array == null) return false;
    else if (array.Length == 0 || array[0] != 0) return false;
    else return true;

}

Console.WriteLine(CheckFirstElement(null));
Console.WriteLine(CheckFirstElement(new int[0]));
Console.WriteLine(CheckFirstElement(new[] { 1 }));
Console.WriteLine(CheckFirstElement(new[] { 0 }));


///////////////////////////////////////////////////////////////////////////////////////////////////////
///
Console.WriteLine("\n\nЗадание: Возвести массив в степень\n");

var arrayToPower = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

// Метод PrintArray уже написан за вас
PrintArray(GetPoweredArray(arrayToPower, 1));

// если вы будете менять исходный массив, то следующие два теста сработают неверно:
PrintArray(GetPoweredArray(arrayToPower, 2));
PrintArray(GetPoweredArray(arrayToPower, 3));

// не забывайте про частные случаи:
PrintArray(GetPoweredArray(new int[0], 1));
PrintArray(GetPoweredArray(new[] { 42 }, 0));

static void PrintArray(int[] arr)
{
    foreach (int i in arr)
    {
        Console.Write(i + " ");
    }

    Console.WriteLine();
}
static int[] GetPoweredArray(int[] arr, int power)
{
    var poweredArray = new int[arr.Length];

    for (int i = 0; i < arr.Length; i++)
    {
        poweredArray[i] = (int)Math.Pow(arr[i], power);
    }

    return poweredArray;
}


Console.ReadLine();

enum Suits
{
    Wands,
    Coins,
    Cups,
    Swords
}