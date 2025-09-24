namespace HomeWork
{
    internal class Program
    {
        private class ListTask
        {
            private readonly List<string> _list = new List<string> { "Элемент 1", "Элемент 2", "Элемент 3" };

            public void TaskLoop()
            {
                Console.WriteLine("Для выхода введите '-exit'");

                while (true)
                {
                    Console.WriteLine("\nТекущий список:");
                    foreach (var item in _list)
                        Console.WriteLine(item);

                    Console.Write("\nВведите новую строку для добавления в конец списка: ");
                    string input = Console.ReadLine();

                    if (input.ToLower() == "-exit")
                        break;

                    _list.Add(input);

                    Console.Write("Введите строку для добавления в середину списка: ");
                    string middleInput = Console.ReadLine();

                    if (middleInput.ToLower() == "-exit")
                        break;

                    _list.Insert(_list.Count / 2, middleInput);
                }
            }
        }

        private class DictionaryTask
        {
            private readonly Dictionary<string, double> _grades = new Dictionary<string, double>();

            public void TaskLoop()
            {
                Console.WriteLine("Задача 2: Работа со словарем оценок");
                Console.WriteLine("Для выхода введите '-exit'");

                while (true)
                {
                    Console.Write("\nВведите имя студента: ");
                    string name = Console.ReadLine();

                    if (name.ToLower() == "-exit")
                        break;

                    Console.Write("Введите оценку (2-5): ");
                    if (int.TryParse(Console.ReadLine(), out int grade) && grade >= 2 && grade <= 5)
                    {
                        _grades[name] = grade;
                    }
                    else
                    {
                        Console.WriteLine("Некорректная оценка! Должно быть число от 2 до 5.");
                        continue;
                    }

                    Console.Write("\nВведите имя студента для поиска оценки: ");
                    string searchName = Console.ReadLine();

                    if (searchName.ToLower() == "-exit")
                        break;

                    if (_grades.TryGetValue(searchName, out double foundGrade))
                    {
                        Console.WriteLine($"Оценка студента {searchName}: {foundGrade}");
                    }
                    else
                    {
                        Console.WriteLine("Студент не найден!");
                    }
                }
            }
        }

        private class LinkedListTask
        {
            private class Node
            {
                public int Value;
                public Node Next;
                public Node Prev;

                public Node(int value)
                {
                    Value = value;
                }
            }

            private Node _head;
            private Node _tail;

            public void TaskLoop()
            {
                Console.WriteLine("Для выхода введите '-exit'");

                Console.Write("Введите количество элементов (3-6): ");
                if (!int.TryParse(Console.ReadLine(), out int count) || count < 3 || count > 6)
                {
                    Console.WriteLine("Некорректное количество элементов!");
                    return;
                }

                for (int i = 0; i < count; i++)
                {
                    Console.Write($"Введите элемент {i + 1}: ");
                    if (int.TryParse(Console.ReadLine(), out int value))
                    {
                        AddNode(value);
                    }
                    else
                    {
                        Console.WriteLine("Некорректный ввод!");
                        return;
                    }
                }

                Console.WriteLine("\nСписок в прямом порядке:");
                PrintForward();

                Console.WriteLine("\nСписок в обратном порядке:");
                PrintBackward();
            }

            private void AddNode(int value)
            {
                Node newNode = new Node(value);
                if (_head == null)
                {
                    _head = _tail = newNode;
                }
                else
                {
                    _tail.Next = newNode;
                    newNode.Prev = _tail;
                    _tail = newNode;
                }
            }

            private void PrintForward()
            {
                Node current = _head;
                while (current != null)
                {
                    Console.Write($"{current.Value} ");
                    current = current.Next;
                }
            }

            private void PrintBackward()
            {
                Node current = _tail;
                while (current != null)
                {
                    Console.Write($"{current.Value} ");
                    current = current.Prev;
                }
            }
        }
    }
}
    