using System;
using System.Collections.Generic;

namespace biasedProbability
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char,double> probabilities = new Dictionary<char, double>();
            Console.Write("The number of properties(Max 26): ");
            int proNum = Convert.ToInt32(Console.ReadLine());
            char point = 'A';
            double value;
            Random r1 = new Random();
            for(int i=0;i<proNum;i++)
            {
                Console.Write($"{point}=");
                value = Convert.ToDouble(Console.ReadLine());
                probabilities.Add(point,value);
                point++;
            }

            double check = 0.0;
            foreach(var i in probabilities)
            {
                check += i.Value;
            }
            if (check != 1.0)
                return;
            else
            {

                double pivot = r1.NextDouble();
                foreach (var i in probabilities)
                {
                    pivot -= i.Value;
                    if (pivot <= 0)
                    { Console.WriteLine($"Output Property item: {i.Key}"); return; }
                    else
                        continue;
                }
            }
        }
    }
}
