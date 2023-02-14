string [] array = new string[4] {"hello", "2", "world", ":-)"};
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if(array[i].Length <= 3) count++;
}

string [] array2 = new string[count];
void NewArrayWithCondition(string[] array, string[] array2)
{
    count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
        {
            array2[count] = array[i];
            count++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

PrintArray(array);
NewArrayWithCondition(array, array2);
PrintArray(array2);