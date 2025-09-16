using System.Diagnostics.CodeAnalysis;

namespace HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задание №1: Числа Фибоначчи
            int a = 0, b = 1;
            for (int i = 0; i < 10; i++){
                Console.Write(a + " ");
                int temp = a;
                a = b;
                b = temp + b;}
            Console.WriteLine();

            //Задание №2: Четные числа
            for (int i = 2; i <= 20; i += 2){
                Console.Write(i + " ");}
            Console.WriteLine();

            //Задание №3: Таблица умножения
            for (int i = 1; i <= 5; i++){
                for (int j = 1; j <= 5; j++)
                {
                    Console.Write($"{i * j}\t");
                }
                Console.WriteLine();}

            //Задание №4: Ввод пароля
            string password = ("qwerty");
            Console.WriteLine("Введите пароль:");
            string Input = Console.ReadLine();
            if (Input == password)
            {
                Console.WriteLine("Пароль верный!");
            }
            else
            {
                Console.WriteLine("Неверный пароль!");
            }
        }
    }
}