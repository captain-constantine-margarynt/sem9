/*Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

using System;
using static System.Console;
Clear();
WriteLine("Введите число N: ");
int n =int.Parse(ReadLine());
WriteLine("Введите число M: ");
int m =int.Parse(ReadLine());

int sum = counter(n,m);
WriteLine(sum);

int counter(int n, int m){
    int sum = 0;
    int [] result = new int [m];
        if(m==n){
        WriteLine("Числа равны!");
        sum = 0;
        return sum;
    } else if ( m > n){
        for (int i = n; i <= m; i++){
            sum += i;
        }
            return sum;
    } else if ( m < n){
        for (int i = m; i <= n; i++){
            sum += i;
        }
    }
    return sum;
}

