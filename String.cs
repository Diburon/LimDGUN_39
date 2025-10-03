using System.Text;

namespace HomeWork
{
    internal class Program
    {
        // Задача №1. Конкатенация двух строк
        public static string ConcatenateStrings(string str1, string str2)
        {
            return str1 + str2;
        }

        // Задача №2. Приветствие
        public static string GreetUser(string name, int age)
        {
            return $"Hello, {name}! You are {age} years old.\n";
        }

        // Задача №3. Регистры
        public static string GetStringInfo(string input)
        {
            return $"Количество символов: {input.Length}\n" +
                   $"Верхний регистр: {input.ToUpper()}\n" +
                   $"Нижний регистр: {input.ToLower()}";
        }

        // Задача №4. Получение первых 5 символов
        public static string GetFirstFiveChars(string input)
        {
            if (input.Length < 5)
                return input;
            return input.Substring(0, 5);
        }

        // Задача №5. Append
        public static StringBuilder JoinStrings(string[] strings)
        {
            var builder = new StringBuilder();
            foreach (var str in strings)
            {
                builder.Append(str).Append(" ");
            }
            return builder;
        }

        // Задача №6. Метод для замены слов в строке
        public static string ReplaceWords(string inputString, string wordToReplace, string replacementWord)
        {
            return inputString.Replace(wordToReplace, replacementWord);
        }

        static void Main(string[] args)
        {
            // Тестирование метода 1
            Console.WriteLine("Тест ConcatenateStrings:");
            Console.WriteLine(ConcatenateStrings("Hello, ", "world!"));
            Console.WriteLine();

            // Тестирование метода 2
            Console.WriteLine("Тест GreetUser:");
            Console.Write(GreetUser("Tommy", 19));
            Console.WriteLine();

            // Тестирование метода 3
            Console.WriteLine("Тест GetStringInfo:");
            Console.WriteLine(GetStringInfo("Hello World"));
            Console.WriteLine();

            // Тестирование метода 4
            Console.WriteLine("Тест GetFirstFiveChars:");
            Console.WriteLine(GetFirstFiveChars("HelloWorld"));
            Console.WriteLine(GetFirstFiveChars("Hi"));
            Console.WriteLine();

            // Тестирование метода 5
            Console.WriteLine("Тест JoinStrings:");
            var result = JoinStrings(new[] { "Hello", "world", "from", "Netology" });
            Console.WriteLine(result.ToString());
            Console.WriteLine();

            // Тестирование метода 6
            Console.WriteLine("Тест ReplaceWords:");
            string replaced = ReplaceWords("Hello world, world is big", "world", "universe");
            Console.WriteLine(replaced);
        }
    }
}
