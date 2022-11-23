// Написать программу, которая из имеющегося массива строк 
// формирует массив из строк, длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать 
// на старте выполнения алгоритма. При решении не рекомендуется 
// пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] array = { "hello", "world", "i", "am", "Roman", "Makulin", "1998", ":-)" };
string[] array2 = new string[array.Length];
int n = 3;

StringWithNElements(array, array2);
PrintArray(array2);

void StringWithNElements(string[] array, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= n)
        {
            array2[count] = array[i];
            count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++) System.Console.Write($"{array[i]} ");
}