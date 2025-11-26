using System;
using System.IO;
using System.Linq;
using System.Text;

namespace Lab9_Variant3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string inputPath = "input.txt";
            string outputPath = "output.txt";

            Console.WriteLine("=== Вариант 3: Удаление пустых строк ===");

            if (File.Exists(inputPath))
            {
                // Читаем строки и сразу фильтруем (LINQ)
                // Where оставляет только те строки, которые НЕ являются пустыми или пробельными
                var lines = File.ReadAllLines(inputPath)
                                .Where(line => !string.IsNullOrWhiteSpace(line));

                File.WriteAllLines(outputPath, lines);
                Console.WriteLine($"Обработка завершена. Результат в '{outputPath}'.");
            }
            else
            {
                Console.WriteLine($"Файл '{inputPath}' не найден.");
            }

            Console.ReadKey();
        }
    }
}