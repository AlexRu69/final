//Напишите программу которая из имеющегося массива строк создаёт
//  массив в котором все строки меньше иле ровны
// трём символам. 

Console.Clear();

string[] originalArray = { "hello", "123", "string", "hed", "5", "!.&", "homework" };



string[] GetNewArray(string[] array)
{
    int size = 0;
    for (int j = 0; j < array.Length; j++)
    {
        if(array[j].Length <= 3)
        size++;
    }

    string[] newArray = new string[size];
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
        {
            newArray[count] = array[i];
            count++;
        }
    }
    return newArray;
}

void PrintArray(string[] inarray) 
{
    for (int i = 0; i  <inarray.Length; i++)
    {
        Console.Write($"{inarray[i]} ");
    }
}

string[] result = GetNewArray(originalArray);
System.Console.Write("[ ");
PrintArray(result);
System.Console.WriteLine("]");


