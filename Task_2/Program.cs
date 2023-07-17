/*
 Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
Console.WriteLine(" input number M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" input number N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int PrintSum(int M, int N)
{
    if(M==N)return N;
    else return  M + PrintSum(M+1, N);
}
Console.WriteLine(PrintSum(M, N));

