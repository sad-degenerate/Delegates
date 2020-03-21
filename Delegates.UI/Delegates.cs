using System;

namespace Delegates.UI
{
    public delegate double Operation(double arg);

    public class Delegates
    {
        public Operation[] GetDelegates(int count, int seed)
        {
            var operations = new Operation[count];

            var rand = new Random(seed);

            for(int i = 0; i < count; i++)
            {
                switch(rand.Next(0, 4))
                {
                    case 0:
                        operations[i] = Add;
                        break;

                    case 1:
                        operations[i] = Mult;
                        break;

                    case 2:
                        operations[i] = Min;
                        break;

                    case 3:
                        operations[i] = DivBy2;
                        break;

                    case 4:
                        operations[i] = MultBy2;
                        break;
                }
            }

            return operations;
        }

        private double Add(double arg)
        {
            return arg + 10;
        }

        private double Mult(double arg)
        {
            return arg * 10;
        }

        private double Min(double arg)
        {
            return arg - 10;
        }

        private double DivBy2(double arg)
        {
            return arg / 2;
        }

        private double MultBy2(double arg)
        {
            return arg * 2;
        }
    }
}