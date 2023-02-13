Console.Clear();

// string word = "Hello world";
// string myName = "Nikolay";
// Console.WriteLine(word.Length);
// string[] arrayOfStrings = new string[2];
// arrayOfStrings[0] = word;
// arrayOfStrings[1] = myName;

// void showArray(string[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
// }
//string.Join(", ", array); - Show Array;


string[] stringArray1 = { "hello", "2", "world", ":-)" };
string[] stringArray2 = { "1234", "1567", "-2", "computer science" };
string[] stringArray3 = { "Russia", "Denmark", "Kazan" };

void showFilteredArray(string[] initialAray)
{
    int size = 0;
    int indexArray = 0;
    for (int i = 0; i < initialAray.Length; i++)
    {
        if (initialAray[i].Length <= 3)
        {
            size++;
        }
    }

    string[] arrayFinal = new string[size];
    for (int i = 0; i < initialAray.Length; i++)
    {
        if (initialAray[i].Length <= 3)
        {
            arrayFinal[indexArray] = initialAray[i];
            indexArray++;
        }
    }

    Console.WriteLine($"[{string.Join(", ", arrayFinal)}]");
}

Console.Write($"Initial array: [{string.Join(", ", stringArray1)}]");
Console.WriteLine(' ');
Console.Write("Result: ");
showFilteredArray(stringArray1);