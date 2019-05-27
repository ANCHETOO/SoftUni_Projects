using System;
using System.Collections.Generic;
using System.Linq;

namespace MixedUpLists
{
    class MixedUpLists
    {
        static void Main(string[] args)
        {
            List<double> first = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToList();
            List<double> second = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToList();
            List<double> result = new List<double>();
            second.Reverse();
            int lenht1 = first.Count;
            int lenght2 = second.Count;
            double maxEl = 0;
            double minEl = 0;

            if (lenht1 == lenght2)
            {
                maxEl = first[first.Count - 1];
                minEl = second[second.Count - 1];

                if (maxEl < minEl)
                {
                    maxEl = maxEl + minEl;
                    minEl = maxEl - minEl;
                    maxEl = maxEl - minEl;
                }

                first.RemoveAt(first.Count - 1);
                second.RemoveAt(second.Count - 1);
                GetElements(result, first, maxEl, minEl);
                GetElements(result, second, maxEl, minEl);
            }
            else if (lenht1 > lenght2)
            {
                maxEl = first[first.Count - 1];
                minEl = first[first.Count - 2];

                if (maxEl < minEl)
                {
                    maxEl = maxEl + minEl;
                    minEl = maxEl - minEl;
                    maxEl = maxEl - minEl;
                }

                first.RemoveAt(first.Count - 1);
                first.RemoveAt(first.Count - 1);
                GetElements(result, first, maxEl, minEl);
                GetElements(result, second, maxEl, minEl);
            }
            else
            {
                maxEl = second[second.Count - 1];
                minEl = second[second.Count - 2];

                if (maxEl < minEl)
                {
                    maxEl = maxEl + minEl;
                    minEl = maxEl - minEl;
                    maxEl = maxEl - minEl;
                }

                second.RemoveAt(second.Count - 1);
                second.RemoveAt(second.Count - 1);
                GetElements(result, first, maxEl, minEl);
                GetElements(result, second, maxEl, minEl);
            }

            result.Sort();
            Console.WriteLine(string.Join(' ', result));
        }

        static List<double> GetElements(List<double> result, List<double> input, double maxEl, double minEl)
        {
            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] > minEl && input[i] < maxEl)
                {
                    result.Add(input[i]);
                }
            }

            return result;
        }
    }
}
