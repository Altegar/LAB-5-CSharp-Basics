// Сушинський Ігор
// Лабораторна робота № 5
// Двовимірні масиви.
// Варіант 3

namespace LAB_5_CSharp
{
    internal class Program
    {
        private static void Create(int[,] a)
        {
            int k = a.GetLength(0);
            int n = a.GetLength(1);

            Random r = new();
            for (int i = 0; i < k; i++)
                for (int j = 0; j < n; j++)
                    a[i, j] = r.Next(-15, 15);
        }

        private static void Print(int[,] a)
        {
            int k = a.GetLength(0);
            int n = a.GetLength(1);

            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write("{0,4}", a[i, j]);
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        private static int FindSmallestOfMaxInOddColumns(int[,] a)
        {
            int k = a.GetLength(0);
            int n = a.GetLength(1);

            int smallestOfMax = int.MaxValue;

            for (int j = 0; j < n; j += 2) // Ітеруємо по непарних стовпцях
            {
                int maxInColumn = a[0, j];
                for (int i = 1; i < k; i++) // Знаходимо максимальний елемент у стовпці
                {
                    if (a[i, j] > maxInColumn)
                        maxInColumn = a[i, j];
                }

                // Оновлюємо найменший з максимальних елементів, якщо поточний максимум менший
                if (maxInColumn < smallestOfMax)
                    smallestOfMax = maxInColumn;
            }

            return smallestOfMax;
        }

        private static void Main(string[] args)
        {
            Console.Write("k = ");
            int k = Convert.ToInt32(Console.ReadLine());

            Console.Write("n = ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[,] a = new int[k, n];
            Create(a);
            Print(a);

            Console.WriteLine($"The smallest of max items in odd columns = {FindSmallestOfMaxInOddColumns(a)}");
        }
    }
}