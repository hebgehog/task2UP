using System.IO;

namespace task2UP
{
    class Program
    {
        public static long minimum = 0;
        public static long counter = 0;
        public static void Main(string[] args)
        {
            StreamWriter writer = new StreamWriter("C:\\Users\\alina\\Desktop\\HSE\\ПРАКТИКА\\ЗАДАЧИ\\ЗАДАЧА 2\\OUTPUT.txt");
            StreamReader reader = new StreamReader("C:\\Users\\alina\\Desktop\\HSE\\ПРАКТИКА\\ЗАДАЧИ\\ЗАДАЧА 2\\INPUT.txt");
            int n = int.Parse(reader.ReadLine());
            for (int i = 1; i <= 9; i++){
                Recurs(n - 1, i, i, i);
            }
            if (n == 1) { writer.WriteLine("10 0"); }
            else { writer.WriteLine(counter + " " + minimum); }
            writer.Close();
            reader.Close();

        }
        public static void Recurs(long i, long a, long d, long s)
        {
            if (i == 0)
            {
                if (d == s)
                {
                    counter++;
                    if (minimum == 0) { minimum = a; }
                }
            }
            else
            {
                if (d < 100)
                {
                    for (int j = 1; j <= 9; j++)
                    {
                        Recurs(i - 1, a * 10 + j, d * j, s + j);
                    }
                }
            }
        }
    }
}