using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("1 Задание:");
            // a:
            Console.WriteLine("Введите переменные a,b,c,d,symbol,status: ");

            int a = Convert.ToInt32(Console.ReadLine());
            decimal b = Convert.ToDecimal(Console.ReadLine());

            float c = Convert.ToSingle(Console.ReadLine());
            double d = Convert.ToDouble(Console.ReadLine());
            char symbol = Convert.ToChar(Console.ReadLine());
            bool status = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine($"Вывод переменных : а = {a}, b= {b}, c= {c}," +
                $" d={d}, symbol = {symbol}, status = {status}");

            second();
            third();
            four();
            fifth();

            int[] numbers = { 1, 2, 3, 4, 5 };
            string text = "Hello";

            // Определение локальной функции
            (int max, int min, int sum, char firstChar) ProcessArrayAndString(int[] arr, string str)
            {
                int max = arr.Max();
                int min = arr.Min();
                int sum = arr.Sum();
                char firstChar = str[0];
                return (max, min, sum, firstChar);
            }

            // Вызов локальной функции
            var result = ProcessArrayAndString(numbers, text);

            // Вывод результата
            Console.WriteLine($"Max: {result.max}, Min: {result.min}, Sum: {result.sum}, First Char: {result.firstChar}");

            // Локальная функция с блоком checked
            void CheckedFunction()
            {
                checked
                {
                    int maxInt = int.MaxValue;
                    Console.WriteLine($"Checked: {maxInt}");
                    try
                    {
                        maxInt++;
                        Console.WriteLine($"Checked after increment: {maxInt}");
                    }
                    catch (OverflowException ex)
                    {
                        Console.WriteLine($"Checked overflow: {ex.Message}");
                    }
                }
            }

            // Локальная функция с блоком unchecked
            void UncheckedFunction()
            {
                unchecked
                {
                    int maxInt = int.MaxValue;
                    Console.WriteLine($"Unchecked: {maxInt}");
                    maxInt++;
                    Console.WriteLine($"Unchecked after increment: {maxInt}");
                }
            }

            // Вызов локальных функций
            CheckedFunction();
            UncheckedFunction();

            Console.WriteLine("Нажмите любую клавишу для продолжения...");
            Console.ReadLine();
        }
        static void second()
        {
            // b
            // Неявное преобразование:
            int a = 15;
            double b = a;

            float c = 12.3f;
            double d = c;

            char symbol = 'f';
            int ascii = symbol; // Выведет код ASCII буквы f

            byte s = 255;
            int y = s;

            short l = 5;
            int p = l;

            // Явное приведение
            double da = 9.78;
            int i = (int)da;

            long ld = 100000;
            short ss = (short)ld;

            float fu = 3.14f;
            int jg = (int)fu;

            object obj = "Hello";
            string str = (string)obj;

            object num = 123;
            int k = (int)num;

            // c:
            // Упаковка: Значимый --> Ссылочный
            int number = 123;
            object numberObj = (object)number;

            // Распакоука: Ссылочный --> Значимый
            object numberObjSecond = 123;
            int numberSecond = (int)numberObjSecond;

            //d: 
            var welcomePhrase = "Welcome to the homepage"; // --> string
            var count = 1230; // --> int
            //e 
            int? nullableInt = null;
            bool nullStatus = nullableInt == null;
            // ... Далее код, при котором значение nullableInt может измениться/Не измениться.
            if (!nullStatus) // Проверка на null
            {
                Console.WriteLine($"Введенное число: {nullableInt}");
            }
            else
            {
                Console.WriteLine("Число не введено");
            }
            //f 
            var errorExample = "Hello";
            //errorExample = 2;

            // Компилятор автоматически определил тип переменной как string, 
            // Присвоение значения другого типа вызывает ошибку.
        }

        static void third()
        {
            Console.WriteLine("2 Задание:");
            // a:
            string stroke1 = "I Love";
            string stroke2 = "OOP";
            string stroke3 = "I Love";

            bool status = stroke1 == stroke3;
            Console.WriteLine($"Строка 1 и Строка 3 равны: {status}");
            status = stroke2 == stroke3;
            Console.WriteLine($"Строка 2 и строка 3 равны: {status}");
            //b 
            // Создание трех строк
            string str1 = "Hello";
            string str2 = "World";
            string str3 = "C# Programming";

            // Сцепление строк
            string concatenated = str1 + " " + str2 + " " + str3;
            Console.WriteLine("Сцепление: " + concatenated);

            // Копирование строки
            string copied = string.Copy(str1);
            Console.WriteLine("Копирование: " + copied);

            // Выделение подстроки
            string substring = str3.Substring(0, 2);
            Console.WriteLine("Выделение подстроки: " + substring);

            // Разделение строки на слова
            string[] words = str3.Split(' ');
            Console.WriteLine("Разделение строки на слова:");
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }

            // Вставка подстроки в заданную позицию
            string inserted = str1.Insert(5, " Beautiful");
            Console.WriteLine("Вставка подстроки: " + inserted);

            // Удаление заданной подстроки
            string removed = inserted.Remove(5, 10);
            Console.WriteLine("Удаление подстроки: " + removed);

            // Интерполяция строк
            string interpolated = $"Interpolated: {str1}, {str2}, {str3}";
            Console.WriteLine(interpolated);

            string empty = "";
            string nullstroke = null;
            bool status1 = string.IsNullOrEmpty(empty); // true
            bool status2 = string.IsNullOrEmpty(nullstroke); //true 
            if (status1 && status2)
            {
                Console.WriteLine("Строки пустые/имеют значение ноль");
            }
            else
            {
                Console.WriteLine("Одна или все строки заполнены");
            }
            // Создание строки на основе StringBuilder
            StringBuilder sb = new StringBuilder("Hello, World!");

            // Удаление определенных позиций (например, удалим "World")
            sb.Remove(7, 5);
            Console.WriteLine("После удаления: " + sb.ToString());

            // Добавление новых символов в начало строки
            sb.Insert(0, "Start: ");
            Console.WriteLine("После добавления в начало: " + sb.ToString());

            // Добавление новых символов в конец строки
            sb.Append(" :End");
            Console.WriteLine("После добавления в конец: " + sb.ToString());
        }
        static void four()
        {
            Console.WriteLine("3 Задание:");
            // a: 
            int[,] matrix = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
            // b:
            string[] array = { "apple", "banana", "cherry", "date", "elderberry" };

            // Выводим содержимое массива на консоль
            Console.WriteLine("Содержимое массива:");
            foreach (string item in array)
            {
                Console.WriteLine(item);
            }

            // Выводим длину массива
            Console.WriteLine("\nДлина массива: " + array.Length);

            // Запрашиваем у пользователя позицию и новое значение
            Console.Write("\nВведите позицию элемента для изменения (0-" + (array.Length - 1) + "): ");
            int position = int.Parse(Console.ReadLine());

            Console.Write("Введите новое значение: ");
            string newValue = Console.ReadLine();

            // Меняем значение элемента в указанной позиции
            if (position >= 0 && position < array.Length)
            {
                array[position] = newValue;
            }
            else
            {
                Console.WriteLine("Неверная позиция!");
            }

            // Выводим обновленное содержимое массива на консоль
            Console.WriteLine("\nОбновленное содержимое массива:");
            foreach (string item in array)
            {
                Console.WriteLine(item);


            }
            // c:
            // Создаем ступенчатый массив
            double[][] jaggedArray = new double[3][];
            jaggedArray[0] = new double[2];
            jaggedArray[1] = new double[3];
            jaggedArray[2] = new double[4];

            // Вводим значения массива с консоли
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write($"Введите значение для jaggedArray[{i}][{j}]: ");
                    jaggedArray[i][j] = double.Parse(Console.ReadLine());
                }
            }

            // Выводим значения массива на консоль
            Console.WriteLine("\nСодержимое ступенчатого массива:");
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j] + "\t");
                }
                Console.WriteLine();
            }
            // d:
            var arr = new int[] { 1 ,2 , 3 };
            var str = "bombom 4 utra";

        }
        static void fifth()
        {
            Console.WriteLine("5 Задание:");
            // a:
            (int age, string name, char sex, ulong height, string haircut) human = (20, "Misha", 'm', 180, "bold");
            // b:
            Console.WriteLine($"Характеристики человека: {human}");
            Console.WriteLine($"Имя человека: {human.name}");
            Console.WriteLine($"Рост человека: {human.height}");
            // c:
            (string name, int age) = ("Tom", 25);
            Console.WriteLine(name); 
            Console.WriteLine(age);
            // d:
            var tuple1 = (name: "Tom", age: 25);
            var tuple2 = (name: "Tom", age: 25);
            var tuple3 = (name: "Jerry", age: 30);

            Console.WriteLine(tuple1 == tuple2); // True
            Console.WriteLine(tuple1 == tuple3); // False
        }
    }
    
}

