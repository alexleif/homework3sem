﻿Console.Clear();
Console.WriteLine(
    $"Задача 68:\nНапишите программу вычисления функции Аккермана с помощью рекурсии.\n"+
    $"Даны два неотрицательных числа m и n.\n"
);
Console.Write("Введите число M: ");
int M = int.Parse(Console.ReadLine());
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine());
Console.Clear();



Console.WriteLine($"{Ackermann(M, N)}");

//Ackermann
int Ackermann(int n, int m){
    if(n == 0){return m + 1;};
    
    if((n != 0) && (m == 0)){
        return Ackermann(n - 1, 1);
    }else{
        return Ackermann(n - 1, Ackermann(n, m - 1));
    };
}