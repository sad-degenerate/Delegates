using System;

namespace Delegates.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            var del = new Delegates();

            for (int j = 0; j < 10; j++)
            {
                double numb = 44;
                
                var count = 10;
                var operations = del.GetDelegates(count, j);

                for (int i = 0; i < count; i++)
                    numb = operations[i](numb);

                Console.WriteLine("{0}-ый ответ: {1}", j, numb);
            }
        }
    }
}