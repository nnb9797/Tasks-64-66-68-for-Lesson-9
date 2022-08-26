using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _64_66_68
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void Zadacha64()
            {
                //Задайте значения M и N. Напишите программу, которая выведет все натуральные числа кратные 3-ём в промежутке от M до N.
                //M = 1; N = 9. -> "3, 6, 9" M = 13; N = 20. -> "15, 18"
                
                int numberM = InputNumbers("Введите начальное число M: ");
                int numberN = InputNumbers("Введите конечное число N: ");

                void Recursion(int m, int n)
                {
                    if (m > n) return;
                    if (m % 3 == 0) Console.Write(m + " ");
                    m += (m % 3 == 0) ? 3 : 1;
                    Recursion(m, n);
                }

                Console.WriteLine($"Числа, кратные 3-м в промежутке от M до N: ");
                Recursion(numberM, numberN);

                int InputNumbers(string input)
                {
                    Console.Write(input);
                    int output = Convert.ToInt32(Console.ReadLine());
                    return output;
                }
                Console.ReadKey();

            }
            void Zadacha66()

            {
                //Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
                //M = 1; N = 15-> 120
                //M = 4; N = 8. -> 30
                int numberM = InputNumbers("Введите начальное число M: ");
                int numberN = InputNumbers("Введите конечное число N: ");
               
                void SumOfElements(int m, int n, int sum)
                {
                    if (m > n)
                    {
                        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N = {sum}");
                        return;
                    }
                    sum = sum + (m++);
                    SumOfElements(m, n, sum);
                }

                SumOfElements(numberM, numberN, 0);

                int InputNumbers(string input)
                {
                    Console.Write(input);
                    int output = Convert.ToInt32(Console.ReadLine());
                    return output;
                }
                Console.ReadKey();
            }


            void Zadacha68()

            {   //Напишите программу вычисления функции Аккермана с помЬ. 
                //Даны два неотрицательных числа m и n.                
                //m = 2, n = 3 -> A(m,n) = 9                           
                //m = 3, n = 2->A(m, n) = 29                  
                int numberM = InputNumbers("Введите начальное неотрицательное число M: ");
                int numberN = InputNumbers("Введите конечное неотрицательное число N: ");

                ///Метод вычисления функции Аккермана:
                int AckermannFunction(int m, int n)
                {
                    return (m == 0) ? n + 1 :
                    (n == 0) ? AckermannFunction(m - 1, 1) : AckermannFunction(m - 1, AckermannFunction(m, n - 1));
                }

                Console.WriteLine($"Функция Аккермана для введенных чисел {numberM} и {numberN} = {AckermannFunction(numberM, numberN)}");

                int InputNumbers(string input)
                {
                    Console.Write(input);
                    int output = Convert.ToInt32(Console.ReadLine());
                    return output;
                }
                Console.ReadKey();
            }

            //Zadacha64();
            //Zadacha66();
            //Zadacha68();
        }

    }
}

