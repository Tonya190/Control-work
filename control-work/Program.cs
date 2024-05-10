/*
Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
*/
Console.WriteLine("Введите строки через запятую: ");
string input = Console.ReadLine();
string[] arr = input.Split(',');

int count = 0;
foreach (string str in arr)
{
    if (str.Trim().Length <= 3)
    {
        count++;
    }
}

string[] new_arr = new string[count];
int index = 0;
foreach (string str in arr)
{
    if (str.Trim().Length <= 3)
    {
        new_arr[index] = str.Trim();
        index++;
    }
}