using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14pr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1


            //Console.Write("Введите значение n: ");
            //int n = int.Parse(Console.ReadLine());
            //Stack<int> stack = new Stack<int>();
            //for (int i = 1; i <= n; i++)
            //{
            //    stack.Push(i);//Помещает объект v в стек
            //}
            //Console.WriteLine($"Размер стека: {stack.Count}");
            //Console.WriteLine($"Верхний элемент стека: {stack.Peek()}");
            //Console.WriteLine("Содержимое стека:");
            //while (stack.Count > 0)
            //{
            //    Console.WriteLine(stack.Pop() + " ");//Возвращает элемент, расположенный в верш стека, и извлекает его из стека
            //}
            //Console.WriteLine($"Новая размерность стека: {stack.Count}");
            //Console.ReadKey();
        





            //2

            //    string skobk = File.ReadAllText("t.txt");//путь к файлу с выражением
            //    Console.WriteLine($"Исходное выражение: {skobk}");
            //    Proverka(skobk);//обращение к методу  проверки
            //    string ispr_skob = Pravka(skobk);
            //    Console.WriteLine($"\nИсправленное выражение: {ispr_skob}");
            //    File.WriteAllText("t1.txt", ispr_skob);//создание нового файла для сохранения исправного выражения
            //    Console.WriteLine("\nИсправленное выражение записано в файл t1.txt");
            //    Console.ReadKey();
            //}



            ////методы ниже относятся к второму заданию




            //static void Proverka(string skob)
            //{
            //    var stack = new Stack();
            //    bool balans = true;//правильность расстановки скобок

            //    for (int i = 0; i < skob.Length; i++)
            //    {
            //        if (skob[i] == '(') stack.Push(i+1);
            //        else if (skob[i] == ')')
            //        {
            //            if (stack.Count > 0) stack.Pop();
            //            else
            //            {
            //                Console.WriteLine($"Лишняя ')' в позиции: {i+1}");
            //                balans = false;
            //            }
            //        }
            //    }

            //    while (stack.Count > 0)
            //    {
            //        Console.WriteLine($"Лишняя '(' в позиции: {stack.Pop()}");
            //        balans = false;
            //    }

            //    if (balans) Console.WriteLine("Скобки сбалансированы");
            //}


            //static string Pravka(string ind)
            //{
            //    Stack one_skob = new Stack();
            //    ArrayList two_skob = new ArrayList(); //для лишних ')'
            //    for (int i = 0; i < ind.Length; i++)//проходимсяпо всему выражению
            //    {
            //        if (ind[i] == '(')//лишня открывающая
            //        {
            //            one_skob.Push(i);
            //        }
            //        else if (ind[i] == ')')
            //        {
            //            if (one_skob.Count > 0)//лишняя закрывающая
            //            {
            //                one_skob.Pop();
            //            }
            //            else
            //            {
            //                two_skob.Add(i);
            //            }
            //        }
            //    }
            //    string result = " "; 
            //    for (int i = 0; i < ind.Length; i++)
            //    {
            //        char zn = ind[i];
            //        bool dop_skob = true;
            //        if (zn == '(' && one_skob.Contains(i))//содержится ли i
            //        {
            //            dop_skob = false;
            //        }
            //        if (zn == ')' && two_skob.Contains(i)) // прверяем на лишнюю закрывающую скобку
            //        {
            //            dop_skob = false;
            //        }
            //        if (dop_skob)
            //        {
            //            result += zn;
            //        }
            //    }
            //    return result;

            }
        }

    }
