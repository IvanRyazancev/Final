﻿/* Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
*/

string[] FirstArray = {"fbdg", "123", "-=", "1516541", "fdvb", "jf", "15"};
string[] SeconArray = new string[FirstArray.Length];
int count = 0;

for (int i = 0; i < FirstArray.Length; i++)
{
    if (FirstArray[i].Length <= 3)
    {
        SeconArray[count] = FirstArray[i];
        count ++;
    }
}
for (int i = 0; i < count; i++)
{
    Console.Write(" [" + SeconArray[i] + "] ");
}