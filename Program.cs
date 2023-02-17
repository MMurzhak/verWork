/* Написать программу, которая из имеющегося массива строк формирует массив из строк, длинна которых
меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатура, либо задать на старте
выполнения алгоритма.При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно
массивами.*/

Console.Clear();

string[] array = new string[GetNumberFromUser()];
FillArray(array);

Console.Write($"[{String.Join(",", array)}] => ");

string[] result = CheckArray(array);
CheckArray(array);
GetLengthArray(result);
PrintArray(result);

int GetNumberFromUser()
{
     
        while(true)
        {
            Console.Write($"Введите длину массива: ");
            bool isCorrect = int.TryParse(Console.ReadLine(), out int num);
            if(isCorrect)
            {
                return num;
               
            }
            else Console.WriteLine("Ошибка ввода! ");
        }
    
}

void FillArray(string[] collection)
{
    for(int i = 0; i < collection.Length; i++)
    {
            Console.Write($"Введите {i+1}-й элемент массива: ");
            string str = Console.ReadLine();
            collection[i] = str;
    }
}

string[] CheckArray(string[] arr)
{
    
    string[] res = new string[arr.Length];
    int j = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
            {
                res[j] = arr[i];
                j++;  
            }
    }
    
    return res;
}

int GetLengthArray(string[] arr)
{
    int cnt = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] != null) cnt++;
    }
    return cnt;
}

void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < GetLengthArray(result); i++)
    {
        Console.Write($"{arr[i]}");
        if (i != GetLengthArray(result) - 1) Console.Write(",");
    }
    Console.Write("]");
}