using System.Diagnostics.CodeAnalysis;

namespace HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задание №1: Числа Фибоначчи
            int[] f = new[] { 0, 1, 1, 2, 3, 5, 8, 13 };

            //Задание №2: 12 месяцев
            string[] month = new string[12] {
                "January","February","March","April",
                "May","June","July","August",
                "September","October","November","December"};

            //Задание №3: Матрица с числами
            int[,] matrix = new int[3, 3] {
            { (int)Math.Pow(2, 1), (int)Math.Pow(3, 1), (int)Math.Pow(4, 1) },
            { (int)Math.Pow(2, 2), (int)Math.Pow(3, 2), (int)Math.Pow(4, 2) },
            { (int)Math.Pow(2, 3), (int)Math.Pow(3, 3), (int)Math.Pow(4, 3) }};


            //Задание №4: Ломанный массив
            double[][] steps = new double[3][];
            steps[0] = new double[5] { 1, 2, 3, 4, 5 };
            steps[1] = new double[] { Math.E, Math.PI };
            steps[2] = new double[]{
            Math.Log10(1),
            Math.Log10(10),
            Math.Log10(100),
            Math.Log10(1000)};

            //Задания №5 и №6
            int[] array = { 1, 2, 3, 4, 5 };
            int[] array2 = { 7, 8, 9, 10, 11, 12, 13 };
            Array.Copy(array, 0, array2, 0, 3);
            Array.Resize(ref array, array.Length * 2);
        }
    }
}