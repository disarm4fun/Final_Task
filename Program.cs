string[] array = {"GeekBrains","0","helloworld"};
string[] newArray = new string[array.Length];
SymbolArray(array,newArray);
PrintArray(newArray);

void SymbolArray(string[] array,string[] newArray)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
        {
            newArray[count] = array[i];
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
