/*Задача 64: Задайте значение N. Напишите программу, 
которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

using System;
using static System.Console;
Clear();
WriteLine("Введите число N: ");
int n =int.Parse(ReadLine());


int [] result = numbers(n);
WriteLine();
WriteLine($"Все числа от 0 до N: ");
WriteLine(String.Join(" ", result));



int [] numbers (int n){
    int [] result = new int [n+1];
    for (int i=0; i < n+1; i++){
        result[i]=i;
    }
    return result;
}