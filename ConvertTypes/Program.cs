using System;

namespace ConvertTypes
{
    class Program
    {
        static void Main(string[] args)
        {

            if (int.TryParse("123", out int result)) //если получиться преобразовать переменную, тогда выполняется код
            {
                Console.WriteLine(result);          //типа try except
            }

            int i = int.Parse("42");

            string s = "str " + i;


            Console.WriteLine(i);
            Console.WriteLine(s);
            Console.ReadLine();
        }
    }
}
